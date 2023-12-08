// Define pin numbers for LEDs and switches
const int led1Pin = 2;
const int led2Pin = 3;
const int switch1Pin = 4;
const int switch2Pin = 5;

void setup() {
  // Initialize serial communication
  Serial.begin(9600);

  // Set LED and switch pins as inputs or outputs
  pinMode(led1Pin, OUTPUT);
  pinMode(led2Pin, OUTPUT);
  pinMode(switch1Pin, INPUT_PULLUP);
  pinMode(switch2Pin, INPUT_PULLUP);
}

void loop() {
  // Read the state of the switches
  int switch1State = digitalRead(switch1Pin);
  int switch2State = digitalRead(switch2Pin);

  // Control LED 1
  if (switch1State == LOW) {
    digitalWrite(led1Pin, HIGH);
    Serial.println("Switch 1 is ON!");
  } else {
    digitalWrite(led1Pin, LOW);
  }

  // Control LED 2
  if (switch2State == LOW) {
    digitalWrite(led2Pin, HIGH);
    Serial.println("Switch 2 is ON!");
  } else {
    digitalWrite(led2Pin, LOW);
  }

  // Add a small delay to debounce the switches
  delay(50);
}
