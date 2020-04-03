#include <SPI.h>

String inputString = "";         // a String to hold incoming data
boolean isStringComplete = false;

  
void setup() {
  Serial.begin(9600);
}

void loop() 
{
  if(isStringComplete)
  {
    Serial.println("Arduino got: " + inputString);
    inputString = "";
    isStringComplete = false;
  } 
  delay(50);
}
 
void serialEvent() 
{
  while (Serial.available()) 
  {
    // get the new byte:
    char c = (char)Serial.read();
    
    if (c == '\n' || c == "#") 
    {
      isStringComplete = true;      
    }
    else
    {
      inputString += c;
    }
  }
}

