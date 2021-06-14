int myLed[] = {2, 4, 6};
int ledDelay[] = {500, 300, 500};
int i = 0;

void setup() {
  // put your setup code here, to run once:
 for(i = 0; i < 3; i++){
  pinMode(myLed[i],OUTPUT);//핀모드 출력으로 설정
  }
}

void loop() {
  // put your main code here, to run repeatedly:  
 for(i = 0; i < 3; i++){
  digitalWrite(myLed[i],HIGH);//LED에 5V 공급
  delay(ledDelay[i]);
  digitalWrite(myLed[i],LOW);//LED에 0V 공급
  delay(ledDelay[i]);
 }
}
