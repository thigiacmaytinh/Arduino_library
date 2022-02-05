#include <IRremote.h>

int RECV_PIN = 8;

IRrecv irrecv(RECV_PIN);

decode_results results;

void setup()
{
  Serial.begin(9600);
  irrecv.enableIRIn(); // Start the receiver
}

void loop() {
  if (irrecv.decode(&results)) {
  switch(results.value)
  {    
    case 0xFFA25D:
      Serial.println("Button 1");
      break;
    case 0xFF629D:
      Serial.println("Button 2");
      break;
    case 0xFFE21D:
      Serial.println("Button 3");
      break;
    case 0xFF22DD:
      Serial.println("Button 4");
      break;
    case 0xFF02FD:
      Serial.println("Button 5");
      break;
    case 0xFFC23D:
      Serial.println("Button 6");
      break;
    case 0xFFE01F:
      Serial.println("Button 7");
      break;
    case 0xFFA857:
      Serial.println("Button 8");
      break;
    case 0xFF906F:
      Serial.println("Button 9");
      break;
    case 0xFF9867:
      Serial.println("Button 0");
      break;
    case 0xFF6897:
      Serial.println("Button *");
      break;
    case 0xFFB04F:
      Serial.println("Button #");
      break;
    case 0xFF38C7:
      Serial.println("Button OK");
      break;
    case 0xFF18E7:
      Serial.println("Button top");
      break;
    case 0xFF5AA5:
      Serial.println("Button right");
      break;
    case 0xFF4AB5:
      Serial.println("Button bottom");
      break;
    case 0xFF10EF:
      Serial.println("Button left");
      break;
    default:
      Serial.println(results.value, HEX);
      break;
  }
    

    delay(200);
    irrecv.resume(); // Receive the next value
  }
}
