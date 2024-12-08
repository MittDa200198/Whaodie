from pyPS4Controller.controller import Controller


class MyController(Controller):

    def __init__(self, **kwargs):
        Controller.__init__(self, **kwargs)
        
# hier werden bereits existierende Funktionen ueberschrieben
# und neu deviniert was bei eintreten dieser events passieren
# soll

# Buttons
    def on_x_press(self):
        print("Hello world")
        
    def on_x_release(self):
        #print("Goodby world")
        pass

# Linker Joy-Stick
    def on_L3_up(self, val):
        pass
        
    def on_L3_down(self, val):
        pass
        
    def on_L3_left(self, val):
        pass
        
    def on_L3_right(self, val):
        pass
        
    def on_L3_x_at_rest(self):
        pass
    
    def on_L3_y_at_rest(self):
        pass

# Rechter Joy-Stick
    def on_R3_up(self, val):
        pass
        
    def on_R3_down(self, val):
        pass
        
    def on_R3_left(self, val):
        pass
        
    def on_R3_right(self, val):
        pass
    
    def on_R3_x_at_rest(self):
        pass
    
    def on_R3_y_at_rest(self):
        pass

# R2 Events
    def on_R2_press(self, val):
        # min-val = -32510
        # max-val = 32767
        # grunsaetzlich mal + 32510 um positive Werte zu haben
        # somit ist der maximale wert 32510 + 32767 = 65277 = 100%
        val = round((val + 32510) / 652.77, 2)
        
        #typecast des float "val" auf "str" damit der Wert ausgegeben werden kann
        print("R2:" + str(val))
        
# L2 Events
    def on_L2_press(self, val):
        pass

controller = MyController(interface="/dev/input/js0", connecting_using_ds4drv=False)
controller.listen()