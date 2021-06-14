int buttonPin = 4;
int led = 13;
int buttonState = 0;
void setup() {
  // put your setup code here, to run once:
  pinMode(buttonPin,INPUT);
  pinMode(led, OUTPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
  buttonState = digitalRead(buttonPin);

  if(buttonState == HIGH){
    digitalWrite(led,HIGH);
  }else{
    digitalWrite(led,LOW);
  }
}
