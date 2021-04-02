int led1 = 5;
int led2 = 11;

void setup() {
  // put your setup code here, to run once:
  pinMode(led1,OUTPUT);
  pinMode(led2,OUTPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
  analogWrite(led1,50);
  analogWrite(led2,255);
}
