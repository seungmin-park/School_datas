void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  pinMode(13.OUTPUT);
}
int i;

void loop() {
  // put your main code here, to run repeatedly:
  if(Serial.available() > 0){
    i = Serial.read();
    Serial.println(i);
    if(i == '1') digitalWrite(13,HIGH);
    if(i == '0') digitalWrite(13,LOW);
  }
}
