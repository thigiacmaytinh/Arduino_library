// include the library code:
#include <LiquidCrystal.h>
#include <DFR_LCD_Keypad.h>

// initialize the library by associating any needed LCD interface pin
// with the arduino pin number it is connected to
const int rs = 12, en = 11, d4 = 5, d5 = 4, d6 = 3, d7 = 2;
LiquidCrystal lcd(8,9,4,5,6,7); 
DFR_LCD_Keypad keypad(A0, &lcd);

int last_key, key;
void setup() {
  lcd.begin(16,2);
  lcd.clear();
  
  lcd.setCursor(0,0);
  lcd.print("Press keys now");
  Serial.begin(9600);
}


void loop() {
  last_key = keypad.get_last_key();
  key      = keypad.read_key();
  

  if (key != last_key) {
    
    lcd.clear();
    lcd.setCursor(0,0);
    
    switch (key) {
      case KEY_RIGHT:
        lcd.print("RIGHT");
        break;
        
      case KEY_UP:
        lcd.print("UP");
        break;
        
      case KEY_DOWN:
        lcd.print("DOWN");
        break;
        
      case KEY_LEFT:
        lcd.print("LEFT");
        break;

      case KEY_SELECT:
        lcd.print("SELECT");
        digitalWrite(13, HIGH);
        break;
        
      case KEY_NONE:
      default:
        lcd.print("NO KEYS PRESSED");
        lcd.setCursor(0,1);
        lcd.print("PRESS KEYS NOW");
        digitalWrite(13, LOW);
        break;
    }
  }
  
  delay(200);
}


