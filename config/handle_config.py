# -*- coding: utf-8 -*-
"""
Created on Wed Oct 16 10:15:36 2024

@author: BRIERE Etienne
"""

import os

from ALookCom.anim import Anim
from ALookCom.img import Img
import ALookCom.imgFmt as imgFmt
from ALookCom.commandPub import CommandPub
from ALookCom.comBle import ComBle

import nest_asyncio
nest_asyncio.apply()



# =============================================================================
#                        Connection des lunettes en Bluetooth
# =============================================================================

# Nom de l'appareil
name_device = 'ENGO 1 123708'

# Créer l'object "com" via la class "ComBle"
com = ComBle(True)

# Associer le nom de l'appareil à "com"
comName = com.findDeviceByName(name_device)
com.open(comName)


# =============================================================================
#                            Fonctionalités générales
# =============================================================================

# Utilisation des fonctions de la class "CommandPub"
## Créer l'outil "CommandPub"
cmd = CommandPub(com)

## Afficher la liste des configurations présentes dans les lunettes 
list_cfg = cmd.cfgList()
# --> usgCnt = ordre d'utilisation des configurations (maj par "cfgSet" ?)
# --> installCnt = ordre d'installation/mise à jour (maj par "cfgWrite")
# --> isSystem = type de configuration (1 pour système et 0 pour utilisateur) 

## Supprimer une configuration
cmd.cfgDelete('test', usePassword = False, password = 0)

## Lire une configuration de la liste des configurations
cmd.cfgRead('test_agilite')

## Sélectionner la configuration actuelle utilisée pour afficher les images
cmd.cfgSet('test_agilite')

## Afficher la liste des images de la configuration actuelle
rt, list_images = cmd.imgList() 

## Afficher une image sauvegardée dans la configuration actuelle
cmd.imgDisplay(1,0,0) # -> id, x, y (x et y = placement dans les lunettes)

## Afficher la liste des animations de la configuration actuelle
rt, list_anim = cmd.animList()

# Afficher une animation sauvegardée dans la configuration actuelle
cmd.animDisplay(0, 3, 150, 255, 0, 0) # handlerId, id, delay, repeat, x, y

## Identifier l'espace de mémoire disponible 
cmd.cfgFreeSpace()

## Affiche le % de batterie 
cmd.battery()

## Suprime img, anim affichées
cmd.clear()


# =============================================================================
#                      Sauvegarder une image dans les lunettes
# =============================================================================

## Créer/Mettre à jour une liste de configuration dans les lunettes (batterie > 5% pour fonctionner)
cmd = CommandPub(com)
cmd.cfgWrite('test_agilite', 0, password = 0)

## Enregistrer l'image dans cette liste de configuration
### Chemin absolu actuel
current_dir = os.getcwd() 

### Créer l'outil "Img"
img = Img(com)

### Sauvegarder l'image dans la mémoire des lunettes
### id (à définir), filname de l'image (.png, .bmp), fmt (convertion de l'img au format souhaité) 
img.saveImage(1,filename=current_dir+'/cfgDescriptor/test_agilite/img/vierge.png', 
              fmt=imgFmt.MONO_1BPP)
img.saveImage(2, filename=current_dir+'/cfgDescriptor/test_agilite/img/top_left.png', 
              fmt=imgFmt.MONO_1BPP)
img.saveImage(3, filename=current_dir+'/cfgDescriptor/test_agilite/img/top_right.png', 
              fmt=imgFmt.MONO_1BPP)
img.saveImage(4, filename=current_dir+'/cfgDescriptor/test_agilite/img/bottom_left.png', 
              fmt=imgFmt.MONO_1BPP)
img.saveImage(5, filename=current_dir+'/cfgDescriptor/test_agilite/img/bottom_right.png', 
              fmt=imgFmt.MONO_1BPP)
img.saveImage(10, filename=current_dir+'/cfgDescriptor/test_agilite/img/richard.png', 
              fmt=imgFmt.MONO_1BPP)








# =============================================================================
#                      Sauvegarder une animation dans les lunettes
# =============================================================================

# Créer/Mettre à jour une liste de configuration dans les lunettes (batterie > 5% pour fonctionner)
cmd.cfgWrite('test_agilite', 0, password = 0)

# Enregistrer l'animation dans cette liste de configuration
## Chemin absolu actuel
current_dir = os.getcwd() 

## Créer l'outil "Anim"
anim = Anim(com)

## Sauvegarder l'animation dans la mémoire des lunettes
### Sauvegarder un .gif directement
### invertColor = True, inverse les couleurs de l'image 
anim.saveAnimationGif(2, gif = current_dir+'/cfgDescriptor/test_agilite/anim/mario_100x100_v2.gif', 
                      invertColor = True, fmt = imgFmt.MONO_4BPP)

### Sauvegarder une animation créée par l'assemblage successif d'images dans un dossier
anim.saveAnimation (2, folder = current_dir+'/cfgDescriptor/demo/anim/counter-15x25', 
                    fmt = imgFmt.MONO_4BPP, useDeprecateCmd = False)

anim.saveAnimation (4, folder = current_dir+'/cfgDescriptor/test_agilite/anim/test2', 
                    fmt = imgFmt.MONO_4BPP, useDeprecateCmd = False)

# =============================================================================
#                      Afficher une image, animation en live
# =============================================================================

# Chemin absolu actuel
current_dir = os.getcwd() 

# Créer l'outil "Img"
img = Img(com)

# Afficher une image via son filname
img.stream(x = 0, y = 0, filename=current_dir+'/cfgDescriptor/test_agilite/img/richard.png', 
           fmt = imgFmt.STREAM_4BPP_HEATSHRINK, useDeprecateCmd = False)


## Afficher une animation via son filname
img.streamGif(x=100, y=0, gif=current_dir+'/cfgDescriptor/test_agilite/anim/mario_100x100_v2.gif', 
              invertColor = True, repeat = 250)

img.streamGif(x=25, y=0, gif=current_dir+'/cfgDescriptor/demo/anim/loading-31x31.gif', 
              invertColor = False, repeat = 250)




