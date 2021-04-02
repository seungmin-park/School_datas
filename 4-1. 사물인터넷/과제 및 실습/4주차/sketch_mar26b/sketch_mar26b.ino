int led[] = {2, 4, 6};

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);//속도 bawdlate = 9600bps
  for(int j = 0; j < 3; j++){
    pinMode(led[j],OUTPUT);
  }
}
int i;

void loop() {
  // put your main code here, to run repeatedly:
  if(Serial.available() > 0){
    i = Serial.read();
    Serial.println(i);
    if(i == '1'){
      for(int j = 0; j < 3 ; j++){
        digitalWrite(led[j],HIGH);
      }
    }
    if(i == '0') {
      for(int j = 0; j <3 ; j++){
        digitalWrite(led[j],LOW);
      }
    }
  }
}
