# -*- coding: utf-8 -*-
"""
Created on Thu Dec  5 11:23:33 2024

@author: Student
"""

import os
import random
import pandas as pd
import numpy as np

from ALookCom.commandPub import CommandPub
from ALookCom.comBle import ComBle
from ALookCom.xdpchandler import *

import nest_asyncio
import asyncio
from bleak import BleakScanner
nest_asyncio.apply()

from PyQt5 import QtCore, QtGui, QtWidgets
import pyqtgraph as pg


class Ui_MainWindow(object):
    
    def setupUi(self, MainWindow):
        MainWindow.setObjectName("MainWindow")
        MainWindow.resize(695, 556)
        self.centralwidget = QtWidgets.QWidget(MainWindow)
        self.centralwidget.setObjectName("centralwidget")

        # Layout principal pour le central widget
        self.mainLayout = QtWidgets.QVBoxLayout(self.centralwidget)

        # GroupBox pour le test d'agilité
        self.groupBoxStartAgilityTest = QtWidgets.QGroupBox(self.centralwidget)
        self.groupBoxStartAgilityTest.setObjectName("groupBoxStartAgilityTest")
        self.groupBoxStartAgilityTestLayout = QtWidgets.QHBoxLayout(self.groupBoxStartAgilityTest)
        
        # LineEdit for participant name
        self.lineEditAddParticipant = QtWidgets.QLineEdit(self.groupBoxStartAgilityTest)
        self.lineEditAddParticipant.setObjectName("lineEditAddParticipant")
        self.lineEditAddParticipant.setPlaceholderText("Enter participant name...")
        self.groupBoxStartAgilityTestLayout.addWidget(self.lineEditAddParticipant)
        
        # New Button Add Participant
        self.pushButtonAddParticipant = QtWidgets.QPushButton(self.groupBoxStartAgilityTest)
        self.pushButtonAddParticipant.setGeometry(QtCore.QRect(130, 70, 91, 23))
        self.pushButtonAddParticipant.setObjectName("pushButtonAddParticipant")
        self.groupBoxStartAgilityTestLayout.addWidget(self.pushButtonAddParticipant)
        
        # Création et Ajout du bouton STOP dans le GroupBox Agility Test
        self.pushButtonStop = QtWidgets.QPushButton(self.groupBoxStartAgilityTest)
        self.pushButtonStop.setObjectName("pushButtonStop")
        self.groupBoxStartAgilityTestLayout.addStretch()  # Ajouter un espace flexible
        self.groupBoxStartAgilityTestLayout.addWidget(self.pushButtonStop)
        
        # Création et Ajout du bouton START dans le GroupBox Agility Test
        self.pushButtonStart = QtWidgets.QPushButton(self.groupBoxStartAgilityTest)
        self.pushButtonStart.setObjectName("pushButtonStart")
        self.groupBoxStartAgilityTestLayout.addWidget(self.pushButtonStart)

        # Ajout du GroupBox Agility Test dans le Layout principal
        self.mainLayout.addWidget(self.groupBoxStartAgilityTest)

        # GroupBox pour la sortie ActiveLook
        self.groupBoxOutputActiveLook = QtWidgets.QGroupBox(self.centralwidget)
        self.groupBoxOutputActiveLook.setObjectName("groupBoxOutputActiveLook")
        
        # Layout2 pour le GroupBox OuputActiveLook
        self.groupBoxOutputActiveLookLayout = QtWidgets.QVBoxLayout(self.groupBoxOutputActiveLook)

        # Creation et ajout du label de l'image cible dans le GroupBox OutputActiveLook
        self.labelTarget = QtWidgets.QLabel(self.groupBoxOutputActiveLook)
        self.labelTarget.setText("")
        current_dir = os.getcwd()
        self.labelTarget.setPixmap(QtGui.QPixmap(f"{current_dir}/config/img/vierge.png"))
        self.labelTarget.setScaledContents(True) # mettre à l'échelle l'image
        self.labelTarget.setObjectName("labelTarget")
        
        # Ajout de l'image (LabelTarget) dans le Layout2
        self.groupBoxOutputActiveLookLayout.addWidget(self.labelTarget)

        # GroupBox pour la sortie des données
        self.groupBoxOutputData = QtWidgets.QGroupBox(self.centralwidget)
        self.groupBoxOutputData.setObjectName("groupBoxOutputData")
        
        # Layout3 pour GroupBox OutputData
        self.groupBoxOutputDataLayout = QtWidgets.QVBoxLayout(self.groupBoxOutputData)

        # Creation du widget du graphique de sortie PyQtGraph
        self.graph_widget = pg.PlotWidget()
        # Ajout du graphique dans le Layout3
        self.groupBoxOutputDataLayout.addWidget(self.graph_widget)

        ## Appliquer un QSizePolicy pour rendre les GroupBox redimensionnables
        self.groupBoxOutputActiveLook.setSizePolicy(QtWidgets.QSizePolicy.Fixed, QtWidgets.QSizePolicy.Fixed)
        self.groupBoxOutputData.setSizePolicy(QtWidgets.QSizePolicy.Expanding, QtWidgets.QSizePolicy.Expanding)

        # Ajouter les deux GroupBox de sortie dans un layout horizontal
        self.outputLayout = QtWidgets.QHBoxLayout()
        self.outputLayout.addWidget(self.groupBoxOutputActiveLook)
        self.outputLayout.addWidget(self.groupBoxOutputData)

        ## Définir un facteur de stretch pour les GroupBox pour qu'ils occupent l'espace disponible également
        self.outputLayout.setStretchFactor(self.groupBoxOutputActiveLook, 1)
        self.outputLayout.setStretchFactor(self.groupBoxOutputData, 1)

        # Ajouter ce Layout horizontal dans le Layout principal
        self.mainLayout.addLayout(self.outputLayout)

        # GroupBox pour les messages dynamiques
        self.groupBoxShowMessage = QtWidgets.QGroupBox(self.centralwidget)
        self.groupBoxShowMessage.setObjectName("groupBoxShowMessage")

        # Layout4 pour GroupBox Message
        self.groupBoxShowMessageLayout = QtWidgets.QHBoxLayout(self.groupBoxShowMessage)

        # QLabel pour les messages
        self.message_label = QtWidgets.QLabel(self.groupBoxShowMessage)
        self.message_label.setObjectName("message_label")
        self.message_label.setStyleSheet("color: blue; font: bold 7pt;")
        self.message_label.setAlignment(QtCore.Qt.AlignLeft)
        self.message_label.setText("...")

        # Ajout du Qlabel dans le layout4
        self.groupBoxShowMessageLayout.addWidget(self.message_label)

        # Ajout du GroupBoxShowMessage à la fin du Layout principal
        self.mainLayout.addWidget(self.groupBoxShowMessage)
        
        MainWindow.setCentralWidget(self.centralwidget)

        # Menus
        self.menubar = QtWidgets.QMenuBar(MainWindow)
        self.menubar.setGeometry(QtCore.QRect(0, 0, 695, 22))
        self.menubar.setObjectName("menubar")
        self.menuConnect_devices = QtWidgets.QMenu(self.menubar)
        self.menuConnect_devices.setObjectName("menuConnect_devices")
        self.menuBattery = QtWidgets.QMenu(self.menubar)
        self.menuBattery.setObjectName("menuBattery")
        MainWindow.setMenuBar(self.menubar)

        # Barre de statut
        self.statusbar = QtWidgets.QStatusBar(MainWindow)
        self.statusbar.setObjectName("statusbar")
        MainWindow.setStatusBar(self.statusbar)

        # Actions des menus
        self.actionConnect_ActiveLook = QtWidgets.QAction(MainWindow)
        self.actionConnect_ActiveLook.setObjectName("actionConnect_ActiveLook")
        self.actionConnect_IMU = QtWidgets.QAction(MainWindow)
        self.actionConnect_IMU.setObjectName("actionConnect_IMU")
        self.actionBattery_ActiveLook = QtWidgets.QAction(MainWindow)
        self.actionBattery_ActiveLook.setObjectName("actionBattery_ActiveLook")
        self.actionBattery_IMU = QtWidgets.QAction(MainWindow)
        self.actionBattery_IMU.setObjectName("actionBattery_IMU")

        self.menuConnect_devices.addAction(self.actionConnect_ActiveLook)
        self.menuConnect_devices.addAction(self.actionConnect_IMU)
        self.menuBattery.addAction(self.actionBattery_ActiveLook)
        self.menuBattery.addAction(self.actionBattery_IMU)

        self.menubar.addAction(self.menuConnect_devices.menuAction())
        self.menubar.addAction(self.menuBattery.menuAction())

        self.retranslateUi(MainWindow)
        QtCore.QMetaObject.connectSlotsByName(MainWindow)

    def retranslateUi(self, MainWindow):
        _translate = QtCore.QCoreApplication.translate
        MainWindow.setWindowTitle(_translate("MainWindow", "MainWindow"))
        self.groupBoxStartAgilityTest.setTitle(_translate("MainWindow", "Agility Test"))
        self.pushButtonStart.setText(_translate("MainWindow", "START"))
        self.pushButtonStop.setText(_translate("MainWindow", "STOP"))
        self.pushButtonAddParticipant.setText(_translate("MainWindow", "Add participant"))
        self.groupBoxOutputActiveLook.setTitle(_translate("MainWindow", "Output ActiveLook"))
        self.groupBoxOutputData.setTitle(_translate("MainWindow", "Output Data"))
        self.groupBoxShowMessage.setTitle(_translate("MainWindow", "Messages"))
        self.menuConnect_devices.setTitle(_translate("MainWindow", "Connect devices"))
        self.menuBattery.setTitle(_translate("MainWindow", "Battery"))
        self.actionConnect_ActiveLook.setText(_translate("MainWindow", "Connect ActiveLook"))
        self.actionConnect_ActiveLook.setShortcut(_translate("MainWindow", "Ctrl+A"))
        self.actionConnect_IMU.setText(_translate("MainWindow", "Connect IMU"))
        self.actionConnect_IMU.setShortcut(_translate("MainWindow", "Ctrl+I"))
        self.actionBattery_ActiveLook.setText(_translate("MainWindow", "Get ActiveLook Battery"))
        self.actionBattery_IMU.setText(_translate("MainWindow", "Get IMU Battery"))


class BluetoothScanner(QtCore.QThread):
    """Thread secondaire pour scanner les appareils Bluetooth et se connecter à ActiveLook.""" 
    # Signaux pour récupérer les variables transmises au thread principal
    cmd_signal = QtCore.pyqtSignal(object) # reçoit l'objet "cmd" (CommandPub)
    
    connection_status = QtCore.pyqtSignal(bool, str)  # Signal pour afficher le statut de la connexion (succès ou échec)
    request_device_selection = QtCore.pyqtSignal(str, str, int, int, int)  # Signal pour demander un choix

    # Signal provenant du thread principal utilisé dans ce thread secondaire
    device_selected = QtCore.pyqtSignal(int)  # Signal pour renvoyer la sélection de l'utilisateur
    

    async def scan_devices(self):
        """Scan Bluetooth en asynchrone."""
        # Stocké le message dans le signal
        self.connection_status.emit(True, "Scanning Bluetooth devices...")
        
        # Scan des devices dispnibles
        devices = await BleakScanner.discover()
        device_names = [device.name for device in devices if device.name]  # Retourne les noms des devices
        return device_names
        
    def handle_device_scan(self):
        """Gestion des appareils scannés."""
        # Récupérer les noms des devices disponibles avec la fonction scan_devices()
        self.device_names = asyncio.run(self.scan_devices())
        
        # Afficher message d'erreur dans le GUI si aucun device trouvé
        if not self.device_names:
            self.connection_status.emit(False, "No devices found!")
            return
        
        # Afficher les appareils trouvés dans le GUI
        device_list = "\n".join(f"{i + 1}. {name}" for i, name in enumerate(self.device_names))
        self.connection_status.emit(True, f"Devices found:\n{device_list}")
        print (f"Devices found:\n{device_list}")
        
        # Demander à l'utilisateur de choisir un appareil
        self.request_device_selection.emit(
            "Select Device",
            "Enter device number:", 1, 1, len(self.device_names))

        # Attendre la sélection de l'utilisateur
        self.exec_()  # Bloquer jusqu'à la réponse


    def handle_device_selection(self, choice):
        self.choice = choice 
        
        # Recevoir la sélection de l'utilisateur
        self.selected_device = self.device_names[self.choice - 1]
        self.quit()  # Arrêter le thread
        
        
   
    def connect_device_selected(self):
        """Connection à l'appareil ActiveLook choisi."""
        self.handle_device_scan()

        # Device sélectionné par l'utilisateur 
        self.connection_status.emit(True, f"Connecting {self.selected_device}...")
        
        # Création de l'objet "com"
        com = ComBle(True)
        
        # Connection Ble à l'appareil
        com_name = com.findDeviceByName(self.selected_device)
        com.open(com_name)
        
        # Création et stockage de l'objet "cmd" (gère config dans les lunettes,...)
        cmd = CommandPub(com)
        print(f"{cmd.battery()[1]}%")
        self.cmd_signal.emit(cmd)
        
        # Stocké le message dans le signal 
        self.connection_status.emit(True, f"Connected {self.selected_device} ! ({cmd.battery()[1]}%)")


    def run(self):
        """Méthode exécutée dans le thread."""
        self.connect_device_selected()


class IMUScanner(QtCore.QThread):
    """Thread pour scanner l'appareil Movella."""
    # Signal pour transmettre le résultat du scan au thread principal
    device_signal = QtCore.pyqtSignal(object)
    connection_status = QtCore.pyqtSignal(bool, str)
    error_message = QtCore.pyqtSignal(bool, str)
    xdpcHandler_signal = QtCore.pyqtSignal(object)
    
    def scan_imu(self) :
        """Scan appareil Movella."""
        self.connection_status.emit(True, "Scanning Movella Dot devices...")
        
        # Initialisation
        self.xdpcHandler = XdpcHandler()
    
        self.xdpcHandler_signal.emit(self.xdpcHandler)
        
        # Vérifier l'initialisation du SDK pour PC
        if not self.xdpcHandler.initialize():
            self.connection_status.emit(False, "Failed to initialize IMU.")
            self.xdpcHandler.cleanup()
            return
        
        # Scan pour les dispositifs
        self.xdpcHandler.scanForDots()
        # Vérifier les dispositifs détectés
        if len(self.xdpcHandler.detectedDots()) == 0:
            self.connection_status.emit(False, "No Movella DOT devices found.")
            self.xdpcHandler.cleanup()
            return

    def connect_imu(self) :
        # Lancer le scan 
        self.scan_imu()
        
        # Connecter le(s) Dot(s) scanné(s) 
        self.xdpcHandler.connectDots()
        
        # Vérifier la connection
        if len(self.xdpcHandler.connectedDots()) == 0:
            self.error_message.emit(False, "Could not connect to any Movella DOT device(s). Aborting.")
            self.xdpcHandler.cleanup()
            return
        
        # Liste vide des noms des Dots connectés
        list_device_name = []
        
        for device in self.xdpcHandler.connectedDots():
            # Stockage du device dans signal pour l'utiliser dans thread principal
            self.device_signal.emit(device)
            
            # Ajout du nom du device dans la liste
            list_device_name.append(device)
            
            # Message d'erreur si connection à plus d'un DOT
            if len(list_device_name) > 1 :
                self.error_message.emit(False, f"Connected to {len(list_device_name)} DOTs. Log in to a single device !")
                self.xdpcHandler.cleanup()
                return
            
            # Afficher la liste dans le GUI via le signal
            self.connection_status.emit(True, f"Connected to {device.deviceTagName()} ({device.batteryLevel()}%) ")
            
            # Obtenir les profils du dot (facultatif ?)
            filterProfiles = device.getAvailableFilterProfiles()
            print("Available filter profiles:")
            for f in filterProfiles:
                print(f.label())

            print(f"Current profile: {device.onboardFilterProfile().label()}")
            if device.setOnboardFilterProfile("General"):
                print("Successfully set profile to General")
            else:
                print("Setting filter profile failed!")
            
            # Paramètre les données de sortie du .csv
            print("Setting quaternion CSV output")
            device.setLogOptions(movelladot_pc_sdk.RecordingData_Acceleration)
            
    def run(self):
        """Méthode exécutée dans le thread."""
        self.connect_imu()



class MeasurementWorker(QtCore.QThread):
    
    # Signal provenant du thread principal utilisé dans ce thread secondaire
    participant_name_signal = QtCore.pyqtSignal(str)  # Signal pour renvoyer le nom du participant choisi par user
    num_essai_signal = QtCore.pyqtSignal(int)
    running_signal = QtCore.pyqtSignal(bool) # Signal pour indiquer que la boucle démarre ou non
    
    # Signal de ce thread vers le thread principal
    new_x_signal = QtCore.pyqtSignal(float)
    new_y_signal = QtCore.pyqtSignal(float)
    message_signal = QtCore.pyqtSignal(bool, str)

    
    # Signal pour déclencher une fonction du thread principal dans ce thread 
    output_ActiveLook_signal = QtCore.pyqtSignal()  # Signal pour déclencher set_outputActiveLook
    plot_graph_signal = QtCore.pyqtSignal() # Signal pour afficher le graphique dynamique
    
    def __init__(self):
       super().__init__()  
 
       # Initialisation des class 
       self.scanner = BluetoothScanner()
       self.imuscanner = IMUScanner()
       
    
    def get_cmd (self, cmd):
        self.cmd = cmd
        
    def get_device (self, device):
        self.device = device  
   
    def get_participant (self, participant_name):
        self.participant_name = participant_name
        
    def get_num_essai (self, num_essai):
        self.num_essai = num_essai
        
    def get_xdpcHandler(self, xdpcHandler):
        self.xdpcHandler = xdpcHandler
    
    def get_running(self, running):
        self.running = running
    
    def run_test(self):
        """Lancer le test d'agilité."""
        self.message_signal.emit(True, "Recording data...")

        ## Vérifier et créer le dossier si nécessaire
        if not os.path.exists(f'outputs/{self.participant_name}'):
            os.makedirs(f'outputs/{self.participant_name}')
        
        # Filname de sortie en .csv des résultats chaque sujet à chaque essai
        logFileName = f"outputs/{self.participant_name}/{self.participant_name}_{self.num_essai}_full.csv"
        print(f"Enable logging to: {logFileName}")
        if not self.device.enableLogging(logFileName):
            print(f"Failed to enable logging. Reason: {self.device.lastResultText()}")
        
        # Vérifier si appareil est prêt pour la mesure 
        if not self.device.startMeasurement(movelladot_pc_sdk.XsPayloadMode_ExtendedEuler):
            print(f"Could not put device into measurement mode. Reason: {self.device.lastResultText()}")
            return
        
        # Afficher l'image vierge avec l'animation du saut
        self.cmd.imgDisplay(1,0,0) 
        self.cmd.animDisplay(0, 1, 150, 255, 50, 90) # handlerId, id, delay, repeat, x, y

        print("\nMain loop. Recording data for 10 seconds.")
        print("-----------------------------------------")
        
        # Afficher des en-têtes pour voir à quel device appartiennent les données
        ## Affiche le nom du device (exemple : D4:22:CD:00:4B:33)
        s = ""
        s += f"{self.device.bluetoothAddress():42}"
        print("%s" % s, flush=True)
        
        #self.running = True
        has_shown_graph = False
        self.startTime = movelladot_pc_sdk.XsTimeStamp_nowMs()
        
        # Dataframe vide de sortie 
        self.results_acc3D = pd.DataFrame(columns=["temps(s)", "accX", "accY", "accZ", "acc_norm"])

        
        while self.running:
            if self.xdpcHandler.packetsAvailable():
                s = ""
                # Récupérer le packet du device
                packet = self.xdpcHandler.getNextPacket(self.device.portInfo().bluetoothAddress())
                
                if packet.containsOrientation():
                    # Récupérer les données d'accélération sur x, y, z
                    acc3D = packet.freeAcceleration()
                    s += f"AccX:{acc3D[0]:7.2f}, AccY:{acc3D[1]:7.2f}, AccZ:{acc3D[2]:7.2f}| " # ":7.2f" permet d'arrondir à 2 chiffres après ,
                
                    # Calul de la norme acc
                    acc_norm = np.sqrt(acc3D[0]**2 + acc3D[1]**2 + acc3D[2]**2)
                    self.new_y_signal.emit(acc_norm)
                    
                    # Récupérer le temps (en secondes)
                    temps = (movelladot_pc_sdk.XsTimeStamp_nowMs() - self.startTime)/1000
                    self.new_x_signal.emit(temps)
                    print(temps)
                    
                    # Emettre le signal pour appeler plot_graph
                    self.plot_graph_signal.emit()
                    
                    # Nouveau df_acc3D à ajouter 
                    new_df_acc3D = pd.DataFrame({'temps(s)': temps,'accX': [acc3D[0]], 'accY': [acc3D[1]], 
                                                 'accZ': [acc3D[2]], 'acc_norm': [acc_norm]})
                    
                    # Ajouter les acc3D au results_acc3D  
                    self.results_acc3D = pd.concat([self.results_acc3D,new_df_acc3D], ignore_index=True)

                # Créer un dossier de sortie avec nom du participant
                ## Vérifier et créer le dossier si nécessaire
                if not os.path.exists(f'outputs/{self.participant_name}'):
                    os.makedirs(f'outputs/{self.participant_name}')
                    
                # Exporter fichier .csv de sortie
                self.results_acc3D.to_csv(f"outputs/{self.participant_name}/{self.participant_name}_{self.num_essai}.csv", 
                                     index=False, encoding='utf-8', sep=';')
                
                
                # Condition pour afficher l'image dans les lunettes en fonction de la norme de l'acc
                # Choix du seuil (ici 14m/s-2)
                if acc_norm > 14 and not has_shown_graph: 

                    ## Afficher une image aléatoire de la direction cible
                    self.cmd.clear() # coupe l'affichage de l'image actuelle
                    self.target = random.randint(2, 5)
                    self.cmd.imgDisplay(self.target,0,0) 

                    ## Mise à jour du paramètre pour stopper 
                    has_shown_graph = True
                    
                    # Émettre le signal pour appeler set_outputActiveLook                    
                    self.output_ActiveLook_signal.emit()
                
                # Afficher les données d'accélération
                print("%s\r" % s, end="", flush=True)    

         
        #Arrêter la boucle while
        self.stop_test()
            

    
    def stop_test(self):
        """Stopper le test d'agilité."""
        
        print("\n-----------------------------------------", end="", flush=True)
        
        # Réinitialiser l'orientation du device (remise à zéro)
        print(f"\nRénitialisation de l'orientation (par default) du Dot {self.device.portInfo().bluetoothAddress()}: ", end="", flush=True)
        if self.device.resetOrientation(movelladot_pc_sdk.XRM_DefaultAlignment):
            print("OK", end="", flush=True)
        else:
            print(f"NOK: {self.device.lastResultText()}", end="", flush=True)
        print("\n", end="", flush=True) 
        
        print("\nStopping measurement...")

        # Vérifier si le device a arrêté les mesures
        if not self.device.stopMeasurement():
            print("Failed to stop measurement.")
        
        # Vérifier si le device cesse d'enregistrer les données de mesure
        if not self.device.disableLogging():
            print("Failed to disable logging.")


    def run(self):
        """Méthode exécutée dans le thread."""
        self.run_test()


class MainWindow(QtWidgets.QMainWindow):
    """THREAD PRINCIPAL"""
    def __init__(self):
        super().__init__()
        self.ui = Ui_MainWindow()
        self.ui.setupUi(self)

        # Initialisation des class 
        self.worker = MeasurementWorker()
        self.imuscanner = IMUScanner()
        self.scanner = BluetoothScanner()

        # Connecter les boutons à leurs fonctions respectives
        self.ui.actionConnect_ActiveLook.triggered.connect(self.connect_activelook)
        self.ui.actionConnect_IMU.triggered.connect(self.connect_imu)
        self.ui.actionBattery_ActiveLook.triggered.connect(self.battery_ActiveLook)
        self.ui.actionBattery_IMU.triggered.connect(self.battery_IMU)

        self.ui.pushButtonAddParticipant.clicked.connect(self.add_participant)
        self.ui.pushButtonStart.clicked.connect(self.start_test)
        self.ui.pushButtonStop.clicked.connect(self.stop_test)
 
        # Connecter les signaux de la class "BluetoothScanner" à leur fontions 
        self.scanner.cmd_signal.connect(self.connect_activelook)
        self.scanner.connection_status.connect(self.handle_message_groupbox)
        self.scanner.request_device_selection.connect(self.show_device_selection)
        self.scanner.device_selected.connect(self.scanner.handle_device_selection)
        self.scanner.cmd_signal.connect(self.worker.get_cmd)
        
        
        # Connecter les signaux de la class "IMUScanner" à leur fontions 
        self.imuscanner.device_signal.connect(self.handle_imu_scan)
        self.imuscanner.connection_status.connect(self.handle_message_groupbox)
        self.imuscanner.error_message.connect(self.handle_message_window)
        self.imuscanner.device_signal.connect(self.worker.get_device)
        self.imuscanner.xdpcHandler_signal.connect(self.worker.get_xdpcHandler)
        
        
        # Connecter les signaux de la class "MeasurementWorker" à leur fontions  
        self.worker.participant_name_signal.connect(self.worker.get_participant)
        self.worker.running_signal.connect(self.worker.get_running)
        self.worker.num_essai_signal.connect(self.worker.get_num_essai)
        self.worker.output_ActiveLook_signal.connect(self.set_outputActiveLook)
        self.worker.new_x_signal.connect(self.get_new_x)
        self.worker.new_y_signal.connect(self.get_new_y)
        self.worker.message_signal.connect(self.handle_message_groupbox)
        self.worker.plot_graph_signal.connect(self.plot_graph)

        # Initialisation du numéro de l'essai
        self.num_essai = 0
        
        # Configurer le graphique 
        self.ui.graph_widget.setBackground('w')  # Fond blanc
        self.ui.graph_widget.setTitle("Real-time evolution of acceleration", color="b", size="10pt")
        self.ui.graph_widget.setLabel("left", "Acc (m/s²)", color="blue", size="12pt")
        self.ui.graph_widget.setLabel("bottom", "Time (s)", color="blue", size="12pt")
        self.ui.graph_widget.addLegend()
        

    def show_message(self, message, error=False):
        """Affiche un message à l'utilisateur."""
        msg_box = QtWidgets.QMessageBox(self)
        msg_box.setIcon(QtWidgets.QMessageBox.Critical if error else QtWidgets.QMessageBox.Information)
        msg_box.setText(message)
        msg_box.setWindowTitle("Error" if error else "Information")
        msg_box.exec_()
    
    def add_message_to_groupbox(self, message, error=False):
        """
        Met à jour le message affiché dans le groupBoxShowMessage.
    
        :param message: Le texte du message à afficher.
        :param error: Booléen pour indiquer si le message est une erreur (True) ou une information (False).
        """
        # Appliquer un style différent pour les messages d'erreur
        if error:
            self.ui.message_label.setStyleSheet("color: red; font: bold 8pt;")
        else:
            self.ui.message_label.setStyleSheet("color: green; font: bold 8pt;")
    
        # Mettre à jour le texte affiché
        self.ui.message_label.setText(message)


    def handle_message_groupbox(self, success, message):
        """Gestion des messages dans le groupbox"""
        self.add_message_to_groupbox(message, error=not success)

    def handle_message_window (self, success, message) :
        """Gestion des messages dans la fenêtre"""
        self.show_message(message, error=not success)

    
    def show_device_selection(self, title, label, default, min_val, max_val):
        # Afficher le dialogue pour sélectionner un appareil
        choice, ok = QtWidgets.QInputDialog.getInt(self, title, label, default, min_val, max_val)
        if ok:
            self.scanner.device_selected.emit(choice)
            
        else:
            QtWidgets.QMessageBox.warning(self, "Warning", "No device selected!")


    def connect_activelook(self, cmd):
        """Connecte à un appareil ActiveLook."""
        # Lancer le processus de scan Bluetooth (class BluetoothScanner)
        self.scanner.start()
        
        # Stocker objet "cmd" pour son utilisation dans d'autres fonctions 
        self.cmd = cmd
        
    
    def connect_imu(self):
        """Connecte l'IMU via Bluetooth."""
        # Lancer le processus de scan IMU
        self.imuscanner.start()
        
        
    def handle_imu_scan(self, device):
        self.device = device
        
        # Affiche message succès
        self.add_message_to_groupbox(f"Connected to {self.device.deviceTagName()} ({self.device.batteryLevel()}%)")
        
    
    def battery_IMU (self) :
        """Afficher le niveau de batterie de l'IMU."""
        self.add_message_to_groupbox(f"Battery Level IMU : {self.device.batteryLevel()}%")


    def battery_ActiveLook (self) :
        """Afficher le niveau de batterie de l'appareil ActiveLook."""
        self.add_message_to_groupbox(f"Battery Level ActiveLook : {self.cmd.battery()[1]}%")


    def add_participant(self):
        """
        Méthode appelée lorsque le bouton 'Add Participant' est cliqué.
        Récupère le texte du QLineEdit et l'associe à la variable participant_name.
        """
        # Récupérer le texte du QLineEdit
        self.participant_name = self.ui.lineEditAddParticipant.text().strip()
        
        self.worker.participant_name_signal.emit(self.participant_name)
    
        # Vérifier si le champ est vide
        if not self.participant_name:
            self.add_message_to_groupbox("Please enter a participant name.", error=True)
            return

        # Initialiser le test une fois le participant ajouté
        self.initialize_test()

    
    def initialize_test(self):
        """
        Initialise le test pour le participant validé.
        """
        # Initialisation du numéro d'essai
        self.num_essai = 1
        self.worker.num_essai_signal.emit(self.num_essai)

        # Choix de la configuation dans la mémoire des lunettes
        self.cmd.cfgSet('test_agilite') 
        self.cmd.clear()
        
        # Afficher le texte "Ready to start" dans les lunettes 
        self.cmd.imgDisplay(1,0,0)
        self.cmd.txt(190, 140, 4, 1, 20, "Ready to start ?") # x, y, rotation, font (taille de la police), color, texte

        # Afficher le nom du participant et numéro de l'essai
        self.cmd.txt(170, 100, 4, 1, 20, f"{self.participant_name}_{self.num_essai}") 
        self.add_message_to_groupbox(f"Ready to start '{self.participant_name}_{self.num_essai}'")
        
        # Df vide de l'acc de sortie
        # Données sous forme de liste de listes
        dict_acc3D = {'temps(s)':[], 'accX': [], 'accY': [], 'accZ': [], 'acc_norm': []}

          
        # Création du DataFrame des résultats vide (à mettre à la fin de la boucle)
        self.results_acc3D = pd.DataFrame(dict_acc3D)
        

        if not os.path.exists('outputs'):
            os.makedirs('outputs')

       
    def start_test (self):
        """Lancer le test d'agilité."""
        # Effacer les données du graphique 
        self.ui.graph_widget.clear()
        
        # Renommer le graphique
        self.ui.graph_widget.setTitle(f"Real-time evolution of {self.participant_name}_{self.num_essai}'s acceleration", color="b", size="10pt")

        # Tracer une courbe
        self.x_data = []  # Liste pour les valeurs de l'axe X
        self.y_data = []  # Liste pour les valeurs de l'axe Y
        self.curve = self.ui.graph_widget.plot(self.x_data, self.y_data, pen=pg.mkPen(color="r", width=2), name = 'acc', symbol='o', symbolBrush='b')
    
        running = True
        self.worker.running_signal.emit(running)
        self.worker.start()
        
        
        
    def stop_test (self):
        running = False 
        self.worker.running_signal.emit(running)
        
        # Incrémentation du numéro d'essai 
        self.num_essai += 1
        self.worker.num_essai_signal.emit(self.num_essai)

        
        # Afficher le texte "Ready to start" dans les lunettes 
        self.cmd.clear()
        self.cmd.imgDisplay(1,0,0)
        self.cmd.txt(190, 140, 4, 1, 20, "Ready to start ?") # x, y, rotation, font (taille de la police), color, texte

        # Afficher le nom du participant et numéro de l'essai
        self.cmd.txt(170, 100, 4, 1, 20, f"{self.participant_name}_{self.num_essai}") 
        self.handle_message_window(True, f"Data saved to the path : \outputs\{self.participant_name}\{self.participant_name}_{self.num_essai-1}.csv")
        self.add_message_to_groupbox(f"Ready to start '{self.participant_name}_{self.num_essai}'")
        
        
    def set_outputActiveLook(self) :
        # Chemin absolu actuel
        current_dir = os.getcwd() 
        
        # Liste des noms des fichiers images cibles
        list_img = ['vierge', 'top_left', 'top_right', 'bottom_left', 'bottom_right']
        
        # Mettre à jour l'image dans le GUI
        self.ui.labelTarget.setPixmap(QtGui.QPixmap(f"{current_dir}/config/img/{list_img[self.worker.target-1]}.png"))
        self.ui.labelTarget.setScaledContents(True) # mettre à l'échelle l'image
        
    def get_new_x (self, new_x):
        self.new_x = new_x
        
    def get_new_y (self, new_y):
        self.new_y = new_y
    
    def plot_graph(self):
        "Afficher le graphique dynamique dans le GUI"
 
        # Ajouter les points 
        self.x_data.append(self.new_x)
        self.y_data.append(self.new_y)
    
        # Mettre à jour le graphique
        self.curve.setData(self.x_data, self.y_data)
     
        
     
if __name__ == "__main__":
    import sys
    
    app = QtWidgets.QApplication(sys.argv)
    main_window = MainWindow()
    main_window.show()
    sys.exit(app.exec_())


