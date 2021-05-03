#include <LiquidCrystal_I2C.h>

LiquidCrystal_I2C lcd(0x27, 16, 2);
void setup() {
  // put your setup code here, to run once:
  lcd.init();
  lcd.backlight();
}

void loop() {
  // put your main code here, to run repeatedly:
  lcd.setCursor(0,0);
  lcd.print("Welcome to");
  lcd.setCursor(1,1);
  lcd.print("ARDUINO world!");
  delay(3000);
  lcd.clear();
  lcd.setCursor(0,0);
  lcd.print("201844050");
  lcd.setCursor(1,1);
  lcd.print("park seung min");
  delay(3000);
}
