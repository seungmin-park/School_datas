#include <LiquidCrystal_I2C.h>
LiquidCrystal_I2C lcd(0x27,16,2);

void setup(){
  lcd.init();
  lcd.backlight();
}

void loop(){
  lcd.print("Cusror Blink");
  lcd.cursor();
  lcd.blink();
  delay(3000);
  lcd.clear();
  lcd.print("Cusror Blink");
  lcd.noBlink();
  delay(3000);
  lcd.clear();
  lcd.noCursor();
  delay(3000);
  lcd.clear();
}
