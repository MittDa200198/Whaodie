# CPU-Auslastung als Diagramm

#### Benötigte Bibliotheken

Um die an die benötigten Informationen zu gelangen, nutzen wir die **psutil** Bibliothek. Um diese zu Installieren wird **PIP** benötigt:

`$ sudo apt-get install python-pip`

Dann das Paket:

`$ sudo pip install psutil`

```python
#!/usr/bin/python
# coding=utf-8
# Einbindung der notwendigen Grundbibliotheken
import os, sys, time
# Einbindung 0,96 Zoll OLED Display 128x64 Pixel
from lib_oled96 import ssd1306
from smbus import SMBus
from PIL import ImageFont
# Einbindung von Bibliotheken für die gewünschten Funktionen
import psutil
# ----------------------------------------------------------------------------
#  Variablen anlegen
# ----------------------------------------------------------------------------
cpuList = []
scale = 100
# ----------------------------------------------------------------------------
#  Display einrichten
# ----------------------------------------------------------------------------
i2cbus = SMBus(1)        # 0 = Raspberry Pi 1, 1 = Raspberry Pi > 1
oled = ssd1306(i2cbus)
# Ein paar Abkürzungen, um den Code zu entschlacken
draw = oled.canvas
# Display zum Start löschen
oled.cls()
oled.display()
# Schriftarten festlegen
FreeSans08 = ImageFont.truetype('FreeSans.ttf', 8)
FreeSans11 = ImageFont.truetype('FreeSans.ttf', 11)
# ----------------------------------------------------------------------------
#  Hauptprogramm
# ----------------------------------------------------------------------------
while True:
    try:
        # Inhalt des Displays bei jedem Durchlauf neu aufbauen
        draw.rectangle((0,0, oled.width, oled.height), outline=0, fill=0)
    
        # CPU-Auslastung auslesen
        cpu_val = psutil.cpu_percent(interval=1)
        # Momentanwert anzeigen
        draw.text((0, 0), "CPU: " + str(cpu_val) + " %", font=FreeSans11, fill=255)
        # Werte für Diagramm speichern und Länge auf 110 Einträge begrenzen
        cpuList.append(cpu_val)
        if len(cpuList) > 110:
            cpuList.pop(0)
        # Skalierung des Diagramms
        max_val = max(cpuList)
        if max_val <= 100.0:
            scale = 100
        if max_val <= 90.0:
            scale = 90
        if max_val <= 80.0:
            scale = 80
        if max_val <= 70.0:
            scale = 70
        if max_val <= 60.0:
            scale = 60
        if max_val <= 50.0:
            scale = 50
        if max_val <= 40.0:
            scale = 40    
        if max_val <= 30.0:
            scale = 30
        if max_val <= 20.0:
            scale = 20
        if max_val <= 10.0:
            scale = 10
        # Achsen zeichnen
        draw.line((12, 60, oled.width, 60), fill=255)    # X
        draw.line((15, 20, 15, 63), fill=255)            # Y
        draw.line((12, 20, 15, 20), fill=255)            # oberster Skalenwert
        # obersten Y-Wert beschriften
        draw.text((0, 16), str(scale), font=FreeSans08, fill=255)
        # X-Koordinate für ersten Wert festlegen
        X = 17
        # Diagrammwerte zeichnen
        for n in range(len(cpuList)):
            Y = float(40 / float(scale) * cpuList[n])
            draw.line((X, 58, X, 58-Y), fill=255)
            X = X + 1
        # Daten am Display ausgeben
        oled.display()
        # Ausgabe der aktuellen Werte auf der Kommandozeile zum Debuggen
        #print str(cpu_val) + "     |     " + str(max_val) + "     |     " + str(scale) + "     |     " + str(40.0 / float(scale) * float(cpu_val))
    except KeyboardInterrupt:
        oled.cls()
        oled.display()
        sys.exit(0)
```

[Quelle](https://indibit.de/raspberry-pi-cpu-auslastung-als-diagramm-auf-oled-display/)