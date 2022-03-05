/*
 * Kết nối:
 *        CB Mưa          Arduino
 *         VCC              5V
 *         GND              GND
 *         D0               4
 *         A0               A0
 */
void setup()
{
  Serial.begin(9600);
}

void loop()
{
  Serial.print(analogRead(A0));
  Serial.print("  ");
  Serial.println(digitalRead(4));
}
