int LED=2;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  pinMode(LED,OUTPUT);
  digitalWrite(LED,LOW);
}

void loop() {
  // put your main code here, to run repeatedly:
  char data = Serial.read();

  switch (data){
    case 'A':
      digitalWrite(LED,HIGH);
      Serial.println("ON");
      break;
    case 'B': 
      digitalWrite(LED,LOW);
      Serial.println("OFF");
      break;
   }
   data = "";
  }
