#include <LiquidCrystal_I2C.h>
#include <DHT.h>
#define DHTTYPE DHT11
#define DHTPIN 2
DHT dht(DHTPIN, DHTTYPE);
LiquidCrystal_I2C lcd(0x27, 16, 2);

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  Serial.println(F("DHTxx test!"));
  dht.begin();
  lcd.init();
  lcd.backlight();
  lcd.clear();
}

void loop() {
  // put your main code here, to run repeatedly:
  delay(500);
  float tem = dht.readTemperature();
  float hum = dht.readHumidity();

  if(isnan(tem) || isnan(hum)){
    Serial.println(F("Failed to read from DHT sensor!"));
    return;
  }

  lcd.setCursor(1,0); lcd.print("Temp : ");
  lcd.setCursor(8,0); lcd.print(tem,1); lcd.print(" C");
  lcd.setCursor(1,1); lcd.print("Humi : ");
  lcd.setCursor(8,1); lcd.print(hum,1); lcd.print(" %");

  Serial.print("Temperature : "); Serial.print(tem);
  Serial.print("Humidity : ");  Serial.print(hum);
  Serial.print("%");
}
