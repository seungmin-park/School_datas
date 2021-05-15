#define MEASURE_PIN 0
#define INFRARED_PIN 2

float measure_value = 0;
float voltage = 0;
float dustDensity = 0;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  pinMode(INFRARED_PIN,OUTPUT);
  pinMode(MEASURE_PIN,INPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
  digitalWrite(INFRARED_PIN,LOW);
  delayMicroseconds(280);
  measure_value = analogRead(MEASURE_PIN);
  delayMicroseconds(40);
  digitalWrite(INFRARED_PIN,HIGH);
  delayMicroseconds(9680);

  voltage = measure_value * 5.0 / 1024.0;
  dustDensity = (voltage - 0.7) / 0.0005;
  Serial.print("Voltage : ");
  Serial.println(voltage);
  Serial.print("Dust Density : ");
  Serial.println(dustDensity);

  delay(1000);

}
