---
title: "MarkdownFunktions"
date: 2022-05-03
tags:[fett, fett geschrieben, schräg, schräg gestellt, schräg stellen, box, in box herausgehoben, Code einfügen, Links, Images, Bilder, Links und Bilder, Table, Tabelle, Liste, Listen, Unordert List, Ordert List, Footnote, Fußnoten, Strikethrough, durchgestrichen, Highlight, hervorheben, Markdonw Befehle]
---
#### Text Formatieren
**bold text** (fett geschrieben)
*italicized text* (schräg gestellt)
> blockquote (in einer box herausgehoben)

#### Listen
##### Ordert List
1. First item
2. Second item
3. Third item

##### Unordert List
- First item
- Second item
- Third item

#### Checklist
- [x] Create a big Osidian Data Strukture
- [ ] Leon ist smart
- [x] Zum aktuellem ist noch kein Bild gefügt worden

#### Code

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




#### Links & Images
[Youtube](https://www.youtube.com)
![[Monkey.jpg]]

#### Table
| Fach     | Note |
| -------- | ---- |
| Englisch | 4    |
| Mathe    | 3    |
| BESP     | 1    |

#### Footnote
Here's a sentence with a footnote. [^1]  
  
[^1]: This is the footnote.
#### Strikethrough
~~The world is flat.~~ durchgestrichen

#### Highlight
I need to highlight thes ==very important words==.
(hervorheben)