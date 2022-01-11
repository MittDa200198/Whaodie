# Raspberry OLED Display

#### Textausgabe

*draw.text((20,16), "Hier Text", fill=1)*
***draw.text((<x>, <y>), <Inhalt>, [<Schriftart>], [<Formatierung>])***

Die Angabe <x>, <y> steht hier für die Koordinaten auf dem Display, bezogen auf die obere linke Ecke.

#### Ausgabe auf dem Display (Hallo Welt)

Befehl für die Ausgabe auf den Display:
*$ ./display.py*

* ##### Bibliotheken importieren
  
  * *from lib__oled96 import ssd1306*
  * *form smbus import SMBus*

* ##### Display einrichten
  
  * *i2cbus = SMBus(1)*
  * *oled = ssd1306 (i2cbus)*

* ##### Ein paar Abkürzungen, um den Code zu entschlacken
  
  * *draw = oled.canvas*

* ##### Display zum Start löschen
  
  * *oled.cls()*
  * *oled.display()*

* ##### Hallo Welt
  
  * *draw.text((20, 16), "Hallo", fill=1)*
  * *draw.text((60, 40), "Welt!", fill=1)*

* ##### Ausgabe auf Display schreiben
  
  * *oled.display()*

```python
#!/usr/bin/env python
# coding=utf-8

# Bibliotheken importieren
from lib_oled96 import ssd1306
from smbus import SMBus

# Display einrichten
i2cbus = SMBus(1)            # 0 = Raspberry Pi 1, 1 = Raspberry Pi > 1
oled = ssd1306(i2cbus)

# Ein paar Abkürzungen, um den Code zu entschlacken
draw = oled.canvas

# Display zum Start löschen
oled.cls()
oled.display()

# Hallo Welt
draw.text((20, 16), "Hallo", fill=1)
draw.text((60, 40), "Welt!", fill=1)

# Ausgaben auf Display schreiben
oled.display()
```

#### Schriften formatieren - step by step

* ##### Bibliotheken importieren
  
  * *form lib_oled96 import ssd1306*
  * *form smbus import SMBus*
  * *form PIL import ImageFont*

* ##### Display einrichten
  
  * *12cbus = SMBus(1)*
  
  * *oled = ssd1306 (i2cbus)*

* ##### Ein Paar Abkürzungen um den Code zu entschlacken
  
  * *draw = oled.canvas*

* ##### Schriftart festlegen
  
  * *FreeSans12 = ImageFont.truetype ('FreeSans.ttf', 12)*
  * *FreeSans20 = ImageFont.truetype ('FreeSans.ttf', 20)*

* ##### Display zum Start löschen
  
  * *oled.cls()*
  * *oled.display()*

* ##### Hallo Welt
  
  * *draw.text((20, 16), "Hallo", font=FreeSans12, fill=1)*
  * *draw.text((60, 40), "Welt!", font=FreeSans20, fill=1)*

* ##### Ausgabe auf Display schreiben
  
  * *oled.display()*

```python
#!/usr/bin/env python
# coding=utf-8

# Bibliotheken importieren
from lib_oled96 import ssd1306
from smbus import SMBus
from PIL import ImageFont

# Display einrichten
i2cbus = SMBus(1)            # 0 = Raspberry Pi 1, 1 = Raspberry Pi > 1
oled = ssd1306(i2cbus)

# Ein paar Abkürzungen, um den Code zu entschlacken
draw = oled.canvas

# Schriftarten festlegen
FreeSans12 = ImageFont.truetype('FreeSans.ttf', 12)
FreeSans20 = ImageFont.truetype('FreeSans.ttf', 20)

# Display zum Start löschen
oled.cls()
oled.display()

# Hallo Welt
draw.text((20, 16), "Hallo", font=FreeSans12, fill=1)
draw.text((60, 40), "Welt!", font=FreeSans20, fill=1)

# Ausgaben auf Display schreiben
oled.display()
```

#### Formen Zeichnen

* Linie: *draw.line((x1, y1, x2, y2), fill=1)*
* Rechteck (nur Rahmen): *draw.rectangle((x1, y1, x2, y2), outline=1, fill=0)*
* Rechteck (ausgefüllt): *draw.rectangle((x1, y1, x2, y2), outline=1, fill=1)*
* Ellipse: *draw.ellipse((x1, y1, x2, y2), outline=1, fill=0)*
* Polygon: *draw.polygon([(x1, y1), (x2, y2), (x3, y3)], outline=1, fill=0)*
* Die Eckpunkte werden als Array angegeben. `(x1, y1)` erste Ecke, `(x2. y2)` zweite Ecke,
  `(x3, y3)`dritte Ecke, ...
* Bogen: `draw.arc((x1, y1, x2, y2), α1, α2, fill=1)`
  `α1, α2` stehen für den Startwinkel und den Endwinkel, gerechnet im Uhrzeigersinn, begonnen bei 3:00 Uhr. Der Platzbedarf eines Bogens ist der selbe, wie der einer Ellipse, jedoch wird nur der angegebene Winkel gezeichnet.
* mit `oled.height` und `oled.whith` kann man auf dem gesamten Bildschirm zeichnen



#### Bilddateien

* ##### Bibliotheken importieren
  
  * *form lib_oled96 import ssd1306*
  * *form smbus import SMBus*
  * *form PIL import ImageFont*

* ##### Display einrichten
  
  * *12cbus = SMBus(1)*
  
  * *oled = ssd1306 (i2cbus)*

* ##### Ein Paar Abkürzungen um den Code zu entschlacken
  
  * *draw = oled.canvas*

* ##### Schriftart festlegen
  
  * *FreeSans12 = ImageFont.truetype ('FreeSans.ttf', 12)*
  * *FreeSans20 = ImageFont.truetype ('FreeSans.ttf', 20)*

* ##### Display zum Start löschen
  
  * *oled.cls()*
  * *oled.display()*

* ##### Bilddatei Ausgeben
  
  * *draw.bitmap((32, 0), Image.open('pi_logo.png'), fill=1)*
  
* ##### Ausgabe auf Display schreiben
  
  * *oled.display()*

```python
#!/usr/bin/env python
# coding=utf-8
 
# Bibliotheken importieren
from lib_oled96 import ssd1306
from smbus import SMBus
from PIL import Image
 
# Display einrichten
i2cbus = SMBus(1)            # 0 = Raspberry Pi 1, 1 = Raspberry Pi > 1
oled = ssd1306(i2cbus)
 
# Ein paar Abkürzungen, um den Code zu entschlacken
draw = oled.canvas
 
# Display zum Start löschen
oled.cls()
oled.display()
 
# Bilddatei ausgeben
draw.bitmap((32, 0), Image.open('pi_logo.png'), fill=1)
 
# Ausgaben auf Display schreiben
oled.display()
```





#### Bild invertieren

* ##### Bibliotheken importieren

  * *form lib_oled96 import ssd1306*
  * *form smbus import SMBus*
  * *form PIL import ImageFont*

* ##### Display einrichten

  * *12cbus = SMBus(1)*

  * *oled = ssd1306 (i2cbus)*

* ##### Ein Paar Abkürzungen um den Code zu entschlacken

  * *draw = oled.canvas*

* ##### Schriftart festlegen

  * *FreeSans12 = ImageFont.truetype ('FreeSans.ttf', 12)*
  * *FreeSans20 = ImageFont.truetype ('FreeSans.ttf', 20)*

* ##### Display zum Start löschen

  * *oled.cls()*
  * *oled.display()*

* ##### Bilddatei Ausgeben

  * `draw.rectangle((32, 0, 95, 63), outline=1, fill=1)`
  * `draw.bitmap((32, 0), Image.open('pi_logo.png'), **fill=0**)`
    **fill != 1 --> fill = 0**

* ##### Ausgabe auf Display schreiben

  * *oled.display()*

```python
#!/usr/bin/env python
# coding=utf-8
 
# Bibliotheken importieren
from lib_oled96 import ssd1306
from smbus import SMBus
from PIL import Image
 
# Display einrichten
i2cbus = SMBus(1)            # 0 = Raspberry Pi 1, 1 = Raspberry Pi > 1
oled = ssd1306(i2cbus)
 
# Ein paar Abkürzungen, um den Code zu entschlacken
draw = oled.canvas
 
# Display zum Start löschen
oled.cls()
oled.display()
 
# Bilddatei ausgeben
draw.rectangle((32, 0, 95, 63), outline=1, fill=1)
draw.bitmap((32, 0), Image.open('pi_logo.png'), fill=0)
 
# Ausgaben auf Display schreiben
oled.display()
```



[Quelle](https://indibit.de/raspberry-pi-oled-display-128x64-mit-python-ansteuern-i2c/)


