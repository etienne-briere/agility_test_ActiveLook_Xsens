# Test d'agilité réactive avec paire de lunettes à réalité augmentée (ActiveLook) et IMU (Dot Movella)
Ce script a été réalisé via le SDK ActiveLook et le SDK Movella Dot, afin de simplifier l'utilisation d'un test destiné à évaluer l'agilité réactive des participants. 

## Configuration de votre environnement de script Python 

Le SDK Movella Dot est compatible seulement avec les versions 3.7 à 3.10 de Python. Il est conseiller d'utiliser Conda pour créer et utiliser un nouvel environnement. Après ouverture du Powershell Anaconda, utilisez les commandes suivantes pour créer et activer ce nouvel environnement Conda :
```bash
$ conda create -n agility_test python=3.10 
$ conda activate agility_test
```
`agility_test` : nom de votre environnement (modifiable)

**Pour en savoir plus :** https://base.movella.com/s/article/Movella-DOT-PC-SDK-Guide?language=en_US.

## Installation de Spyder (facultatif)
Le script développé a été lancé depuis Spyder, d'autres environnements de développement tels que Visual Code devrait fonctionner également. 
Spyder a été installé via conda qui semble mieux gérer les dépendances que pip. 
```bash
$ conda install spyder
```

## Configuration du SDK ActiveLook
Toutes les commandes du SDK ActiveLook sont comprises dans le dossier `AlookCom`. Pour que toutes les commandes fonctionnent, les packages suivants doivent être installés dans l'environnement : 
```bash
$ pip install pyserial
$ pip install opencv-python
$ pip install bleak
$ pip install nest_asyncio
$ pip install image
$ pip install colormath
$ pip install heatshrink2
```
**Pour en savoir plus :** https://github.com/ActiveLook/Config-Generator.

## Configuration du SDK Movella Dot
Deux solutions d'installation :
1. Suivre les étapes d'installation sur le site officiel : https://base.movella.com/s/article/Movella-DOT-PC-SDK-Guide?language=en_US
2. Dossier `Movella`: comprend déjà le SDK Movella Dot à installer avec l'ensemble de la documentation (.html)
   - Ouvrir le cmd
   - Activer l'environnement `agility_test`
   - Déplacez-vous dans le dossier `\Movella\DOT PC SDK <version>\SDK Files\Python\x64` :
     ```bash
     $ cd '...\Movella\DOT PC SDK <version>\SDK Files\Python\x64'
     ```
   - Installez la bonne version du SDK PC :
     ```bash
     $ pip install movelladot_pc_sdk-<version>-cp<version>-none-win_amd64.whl
     ```
   - Déplacez-vous dans le dossier `\Movella\DOT PC SDK <version>\SDK Files\Examples\python`
     ```bash
     $ cd '...\Movella\DOT PC SDK <version>\SDK Files\Examples\python'
     ```
   - Installez la configuration requise :
     ```bash
     $ pip install -r requirements.txt
     ```

## Configuration de PyQt
PyQt est un framework Python qui permet de créer des applications graphiques (GUI - Graphical User Interface) en utilisant la bibliothèque Qt. 
Les commandes suivantes permettent d'installer les packages nécessaires au fonctionnement de PyQt : 
```bash
$ pip install pyqt5
$ pip install pyqt5-tools
$ pip install pyqtgraph
```
