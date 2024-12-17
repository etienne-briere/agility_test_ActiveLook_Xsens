# -*- coding: utf-8 -*-
"""
Created on Wed Nov 13 16:25:38 2024

@author: Student
"""

import os
import random
import matplotlib.pyplot as plt
import matplotlib.image as mpimg
import pandas as pd
import numpy as np

from ALookCom.commandPub import CommandPub
from ALookCom.comBle import ComBle
from ALookCom.xdpchandler import *

import nest_asyncio
import asyncio
from bleak import BleakScanner
nest_asyncio.apply()


# =============================================================================
#                             IMAGE ---> LUNETTES
# =============================================================================


#----------------------------Connection ble lunettes -------------------------#

# Choix connection Ble des lunettes
choice_ble_lunettes = input("Connecter les lunettes en bluetooth \n1 - Oui\n2 - Non (déjà connectées)\n")
print()

if choice_ble_lunettes == "1" :
    
    # Rechercher l'appareil à connecter 
    ## Fonction pour scanner les appareils disponibles en ble
    async def scan_devices():
        devices = await BleakScanner.discover()
        device_names = [device.name for device in devices if device.name]  # Récupère tous les noms disponibles
        return device_names


    ## Lancer la fonction et récupérer les noms des appareils
    print("Scanning device(s) ble...")
    print()
    device_names = asyncio.run(scan_devices())

    ## Nombre d'appareils trouvés
    nb_device_names = len(device_names)

    ## Afficher le nom des appareils disponibles
    if device_names:
        print("Les appareils trouvés sont :")
        for i_name in range(nb_device_names):
            name = device_names[i_name]
            print(f"{i_name+1}.{name}")
            
    else:
        print("No device found")
    print()
    
    ## Choix de l'appareil à connecter 
    choice_device_ble = int(input("Rentrer le numéro de l'appareil que vous voulez connecter : "))-1
    print()
    
    ## Nom de l'appareil choisi
    name_device_ble = device_names[choice_device_ble]

    # Connection Ble 
    ## Créer l'object "com" via la class "ComBle"
    com = ComBle(True)
    
    ## Associer le nom des lunettes à "com"
    comName = com.findDeviceByName(name_device_ble)
    com.open(comName)

#----------------------Select config dans mémoire lunettes--------------------#

# Identifier la configuration comportant les images cibles dans la mémoire interne
## (class "CommandPub")
cmd = CommandPub(com)

## Sélectionner la configuration actuelle utilisée pour afficher les images
cmd.cfgSet('test_agilite') 

## Afficher l'image "vierge" 
cmd.clear()
cmd.imgDisplay(1,0,0) # -> id, x, y (x et y = placement dans les lunettes)



#----------------------------Connection ble IMU-------------------------------#

# Choix connection Ble de l'IMU
choice_ble_IMU = input("Connecter l'IMU en bluetooth \n1 - Oui\n2 - Non (déjà connecté)\n")
print()

if choice_ble_IMU == "1" :

    # Bouton pour connecter IMU 
    input("Press enter pour connecter l'IMU XSens")
    print()
    
    # Initialisation 
    xdpcHandler = XdpcHandler() # IMU ne peut pas être déjà connecté sinon bug    
    
    # Vérifier l'initialisation du SDK pour PC
    if not xdpcHandler.initialize():
        xdpcHandler.cleanup()
        exit(-1)
    
    # Scanner si des dispositifs Movella DOT peuvent être détectés via Bluetooth
    xdpcHandler.scanForDots()
    
    
    # Si aucun dispositif détecté : fermer les connexions avec tous les dispositifs
    # Movella DOT et détruire le gestionnaire de connexion créé lors de l'initialisation
    if len(xdpcHandler.detectedDots()) == 0:  
        print("No Movella DOT device(s) found. Aborting.")
        xdpcHandler.cleanup()
        exit(-1)
    
    # Connection aux dispositifs Movella DOT détectés via une connexion USB ou Bluetooth
    xdpcHandler.connectDots()
    
    # Si aucune connection identifiée : xdpcHandler.cleanup() pour fermer connexion avec tous les dispositifs
    # Movella DOT et détruire le gestionnaire de connexion créé lors de l'initialisation
    if len(xdpcHandler.connectedDots()) == 0:
        print("Could not connect to any Movella DOT device(s). Aborting.")
        xdpcHandler.cleanup()
        exit(-1)
    
    
    device = xdpcHandler.connectedDots()[0]
    
    # Obtenir les profils du device disponile 
    filterProfiles = device.getAvailableFilterProfiles()
    print("Available filter profiles:")
    for f in filterProfiles:
        print(f.label()) # renvoie "General" ou "Dynamic"

    print(f"Current profile: {device.onboardFilterProfile().label()}")
    if device.setOnboardFilterProfile("General"):
        print("Successfully set profile to General")
    else:
        print("Setting filter profile failed!")

    # Paramètre les données de sortie du .csv
    print("Setting quaternion CSV output")
    #device.setLogOptions(movelladot_pc_sdk.XsLogOptions_QuaternionAndEuler) # full données
    device.setLogOptions(movelladot_pc_sdk.RecordingData_Acceleration) # juste acc

    #print(dir(movelladot_pc_sdk))



#-----------------------------Ajouter participant-------------------------#

# Nom du participant
name_sujet = input("Add a participant : ")

# Initilaisation du numéro d'essai
num_essai = 1

# Df vide de l'acc de sortie
# Données sous forme de liste de listes
dict_acc3D = {'temps(s)':[], 'accX': [], 'accY': [], 'accZ': [], 'acc_norm': []}

   
# Création du dossier de sortie des résultats
## Chemin absolu actuel
current_dir = os.getcwd()

if not os.path.exists('outputs'):
    os.makedirs('outputs')

# Création du DataFrame avec des noms de colonnes (à mettre à la fin de la boucle)
results_acc3D = pd.DataFrame(dict_acc3D)


# Boucle infini
i = 0
while i == 0 : 

    # Filname de sortie en .csv des résultats chaque sujet à chaque essai
    logFileName = f"{name_sujet}_{num_essai}_full.csv"
    print(f"Enable logging to: {logFileName}")
    if not device.enableLogging(logFileName):
        print(f"Failed to enable logging. Reason: {device.lastResultText()}")

    print("Putting device into measurement mode.")
    if not device.startMeasurement(movelladot_pc_sdk.XsPayloadMode_ExtendedEuler):
        print(f"Could not put device into measurement mode. Reason: {device.lastResultText()}")
        continue
    
    #-----------------------------Lancement du test---------------------------#

    # Afficher le texte "Ready to start"
    cmd.txt(190, 140, 4, 1, 20, "Ready to start ?") # x, y, rotation, font (taille de la police), color, texte

    # Afficher le nom du participant et numéro de l'essai
    cmd.txt(170, 100, 4, 1, 20, f"{name_sujet}_{num_essai}") 

    input("Press enter pour lancer le test d'agilite")
    print()

    # Afficher l'image vierge avec l'animation du saut
    cmd.imgDisplay(1,0,0) 
    cmd.animDisplay(0, 1, 150, 255, 50, 90) # handlerId, id, delay, repeat, x, y

        
    print("\nMain loop. Recording data for 10 seconds.")
    print("-----------------------------------------")
    
    # Afficher des en-têtes pour voir à quel device appartiennent les données
    ## Affiche le nom du device (exemple : D4:22:CD:00:4B:33)
    s = ""
    s += f"{device.bluetoothAddress():42}"
    print("%s" % s, flush=True)
    
    # Initialisation d'un paramètre
    has_shown_graph = False    
    
    # Paramétrage du temps (ms) pour réaliser la capture 
    ## Renvoie l'h actuelle en ms depuis le début de l'ère UNIX (1970)
    startTime = movelladot_pc_sdk.XsTimeStamp_nowMs()

    ## Enregistre les données du device pendant n temps (ici 10000ms) 
    while movelladot_pc_sdk.XsTimeStamp_nowMs() - startTime <= 10000:
        if xdpcHandler.packetsAvailable():
            s = ""
            
            # Récupérer le packet du dot
            packet = xdpcHandler.getNextPacket(device.portInfo().bluetoothAddress())
            
            if packet.containsOrientation():
                
                # Récupérer les données d'accélération sur x, y, z
                acc3D = packet.freeAcceleration()
                s += f"AccX:{acc3D[0]:7.2f}, AccY:{acc3D[1]:7.2f}, AccZ:{acc3D[2]:7.2f}| " # ":7.2f" permet d'arrondir à 2 chiffres après ,
            
                # Calul de la norme acc
                acc_norm = np.sqrt(acc3D[0]**2 + acc3D[1]**2 + acc3D[2]**2)
    
                
                # Récupérer le temps (en secondes)
                temps = (movelladot_pc_sdk.XsTimeStamp_nowMs() - startTime)/1000
                
    
                # Nouveau df_acc3D à ajouter 
                new_df_acc3D = pd.DataFrame({'temps(s)': temps,'accX': [acc3D[0]], 'accY': [acc3D[1]], 
                                             'accZ': [acc3D[2]], 'acc_norm': [acc_norm]})
                
                
                # Ajouter les acc3D au results_acc3D  
                results_acc3D = pd.concat([results_acc3D,new_df_acc3D], ignore_index=True)
            
               

            # Créer un dossier de sortie avec nom du participant
            ## Vérifier et créer le dossier si nécessaire
            if not os.path.exists(f'outputs/{name_sujet}'):
                os.makedirs(f'outputs/{name_sujet}')
                
            # Exporter fichier .csv de sortie
            results_acc3D.to_csv(f"outputs/{name_sujet}/{name_sujet}_{num_essai}.csv", 
                                 index=False, encoding='utf-8', sep=';')
            
            
            # Condition pour afficher l'image dans les lunettes en fonction de la norme de l'acc
            # Choix du seuil (ici 14m/s-2)
            if acc_norm > 14 and not has_shown_graph: 

                ## Afficher une image aléatoire de la direction cible
                cmd.clear() # coupe l'affichage de l'image actuelle
                target = random.randint(2, 5)
                cmd.imgDisplay(target,0,0) 
                
                ## Mise à jour du paramètre pour stopper 
                has_shown_graph = True
                
                # =============================================================
                #                         IMAGE ---> CONSOLE
                # =============================================================

                # Chemin absolu actuel
                current_dir = os.getcwd() 

                # Afficher l'image avec "plt"
                list_img = ['vierge', 'top_left', 'top_right', 'bottom_left', 'bottom_right']

                img = mpimg.imread(current_dir + '/cfgDescriptor/test_agilite/img/'+list_img[target-1]+'.png') 
                plt.imshow(img)
                plt.axis('off')  # Pour masquer les axes
                plt.show()
                
            
            # Afficher les données d'accélération
            print("%s\r" % s, end="", flush=True)
            
    
    
    print("\n-----------------------------------------", end="", flush=True)
    
    
    # Graphique de l'acc en fonction du temps
    plt.figure(figsize=((10,8))) # 10=largeur et 8=hauteur de la figure créée
    plt.plot(results_acc3D['temps(s)'],results_acc3D['acc_norm'])
    plt.title(f"{name_sujet}_{num_essai}") 
    plt.xlabel("Temps [s]")
    plt.ylabel("Acc [m.s-2]")
    
    
    #fig1 = plt.gcf() #-> sélectionne la figure actuelle
    plt.show()
    
    # Réinitialiser l'orientation du device (remise à zéro)
    print(f"\nRénitialisation de l'orientation (par default) du Dot {device.portInfo().bluetoothAddress()}: ", end="", flush=True)
    if device.resetOrientation(movelladot_pc_sdk.XRM_DefaultAlignment):
        print("OK", end="", flush=True)
    else:
        print(f"NOK: {device.lastResultText()}", end="", flush=True)
    print("\n", end="", flush=True) 
    
    print("\nStopping measurement...")

    # Vérifier si le device a arrêté les mesures
    if not device.stopMeasurement():
        print("Failed to stop measurement.")
    # Vérifier si le device cesse d'enregistrer les données de mesure
    if not device.disableLogging():
        print("Failed to disable logging.")
    
    # Choix pour arrêter ou lancer un nouveau test
    choice_stop = input("Voulez-vous lancer un nouveau test ? \n1 - Oui (same participant) \n2 - Oui (new participant) \n3 - Non \n4 - Stop et déconnecter l'IMU \n")
    print()
    
    if choice_stop == "1" :
        # Afficher image vierge
        cmd.imgDisplay(1,0,0) # -> id, x, y (x et y = placement dans les lunettes)
        
        num_essai += 1 # ajout d'un essai supplémentaire

    if choice_stop == "2" :
        # Afficher image vierge
        cmd.imgDisplay(1,0,0) # -> id, x, y (x et y = placement dans les lunettes)
        
        # Nom du participant
        name_sujet = input("Add a participant : ")
        
        # Initialiser numéro d'essai
        num_essai = 1 

    if choice_stop == "3" :
        i+= 1 # fin de la boucle while
        cmd.clear()
        
    if choice_stop == "4" :
        # Fermer connexion avec tous les devices et détruire le gestionnaire 
        # de connexion créé lors de l'initialisation
        xdpcHandler.cleanup() 

    
 
