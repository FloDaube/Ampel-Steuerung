//Settings
#include <EEPROM.h>

int A_Pin_RG = A0; // Rot / Grün Pahse Poti
int A_Pin_RR = A1; // Rot / Rot Phase Poti

int D_Pin_A1_R = 2; //Ampel 1 Rot
int D_Pin_A1_Y = 3; //Ampel 1 Gelb
int D_Pin_A1_G = 4; //Ampel 1 Grün

int D_Pin_A2_R = 5; //Ampel 2 Rot
int D_Pin_A2_Y = 6; //Ampel 2 Gelb
int D_Pin_A2_G = 7; //Ampel 2 Grün

int Min_RG = 5; //Angaben in Sekunden
int Max_RG = 30; //Angaben in Sekunden

int Min_RR = 2; //Angaben in Sekunden
int Max_RR = 10; //Angaben in Sekunden

int Value_Y = 2; //Angaben in Sekunden

//Variablen
int Value_RG = 5;
int Value_RR = 5;
unsigned long Time = 0;
int Ampel = 0;

//EEPROM

int Adr_V_RG = 0;
int Adr_V_RR = 1;
int Adr_V_Y  = 2;

void setup() {
    Serial.begin(6900);

    pinMode(D_Pin_A1_R, OUTPUT);
    pinMode(D_Pin_A1_Y, OUTPUT);
    pinMode(D_Pin_A1_G, OUTPUT);
    pinMode(D_Pin_A2_R, OUTPUT);
    pinMode(D_Pin_A2_Y, OUTPUT);
    pinMode(D_Pin_A2_G, OUTPUT);

    Test();

    digitalWrite(D_Pin_A1_G, 1);
    digitalWrite(D_Pin_A2_R, 1);
    Time = millis();
    ReadFromEEPROM();
}

void loop() {
    //LoadPoti();
    SerialEvent();
    AmpelSteuerung();
}

void AmpelSteuerung() {
    if (millis() > Time + Get_Time(Value_RG)) {
        Serial.println("Umstellung");
        Serial.println(String(Ampel));
        Serial.println(String(Time));
        if (Ampel == 0) {
            digitalWrite(D_Pin_A1_Y, 1);
            digitalWrite(D_Pin_A1_G, 0);
            Serial.println("Ampel_1_Yellow&1");
            Serial.println("Ampel_1_Green&0");

            //delay(Get_Time(Value_Y));
            Time = millis();
            while (millis() < Time + Get_Time(Value_Y)) {

            }

            digitalWrite(D_Pin_A1_R, 1);
            digitalWrite(D_Pin_A1_Y, 0);
            Serial.println("Ampel_1_Yellow&0");
            Serial.println("Ampel_1_Red&1");
        }
        else {
            digitalWrite(D_Pin_A2_Y, 1);
            digitalWrite(D_Pin_A2_G, 0);
            Serial.println("Ampel_2_Yellow&1");
            Serial.println("Ampel_2_Green&0");

            //delay(Get_Time(Value_Y));
            Time = millis();
            while (millis() < Time + Get_Time(Value_Y)) {

            }

            digitalWrite(D_Pin_A2_R, 1);
            digitalWrite(D_Pin_A2_Y, 0);
            Serial.println("Ampel_2_Yellow&1");
            Serial.println("Ampel_2_Red&0");
        }

        //delay(Get_Time(Value_RR));
        Time = millis();
        while (millis() < Time + Get_Time(Value_RR)) {

        }

        if (Ampel == 0) {
            digitalWrite(D_Pin_A2_Y, 1);
            Serial.println("Ampel_2_Yellow&1");

            //delay(Get_Time(Value_Y));
            Time = millis();
            while (millis() < Time + Get_Time(Value_Y)) {
            }

            digitalWrite(D_Pin_A2_G, 1);
            digitalWrite(D_Pin_A2_Y, 0);
            digitalWrite(D_Pin_A2_R, 0);
            Serial.println("Ampel_2_Green&1");
            Serial.println("Ampel_2_Yellow&0");
            Serial.println("Ampel_2_Red&0");
        }
        else {
            digitalWrite(D_Pin_A1_Y, 1);

            //delay(Get_Time(Value_Y));
            Time = millis();
            while (millis() < Time + Get_Time(Value_Y)) {
            }

            digitalWrite(D_Pin_A1_G, 1);
            digitalWrite(D_Pin_A1_Y, 0);
            digitalWrite(D_Pin_A1_R, 0);
            Serial.println("Ampel_1_Green&1");
            Serial.println("Ampel_1_Yellow&0");
            Serial.println("Ampel_1_Red&0");
        }


        if (Ampel == 0) {
            Ampel = 1;
        }
        else if (Ampel == 1) {
            Ampel = 0;
        }
        Time = millis();
    }
}

void LoadPoti() {
    //Serial.println("Read Anlaog Input:");
    Value_RG = map(analogRead(A_Pin_RG), 0, 1023, Min_RG, Max_RG);
    //Serial.println("Rot Grün Phase : " + String(Value_RG) + "Sekunden");

    Value_RR = map(analogRead(A_Pin_RR), 0, 1023, Min_RR, Max_RR);
    //Serial.println("Rot Rot Phase : " + String(Value_RG) + "Sekunden");
}

int Get_Time(int _time) {
    return _time * 1000;
}

void Test() {
    Serial.println("Starte Test:");
    digitalWrite(D_Pin_A1_R, 1);
    Serial.println("Ampel_1_Red&1");
    delay(500);
    digitalWrite(D_Pin_A1_Y, 1);
    Serial.println("Ampel_1_Yellow&1");
    delay(500);
    digitalWrite(D_Pin_A1_G, 1);
    Serial.println("Ampel_1_Green&1");
    delay(500);
    digitalWrite(D_Pin_A2_R, 1);
    Serial.println("Ampel_2_Red&1");
    delay(500);
    digitalWrite(D_Pin_A2_Y, 1);
    Serial.println("Ampel_2_Yellow&1");
    delay(500);
    digitalWrite(D_Pin_A2_G, 1);
    Serial.println("Ampel_2_Green&1");
    delay(2000);

    digitalWrite(D_Pin_A1_R, 0);
    digitalWrite(D_Pin_A1_Y, 0);
    digitalWrite(D_Pin_A1_G, 0);
    digitalWrite(D_Pin_A2_R, 0);
    digitalWrite(D_Pin_A2_Y, 0);
    digitalWrite(D_Pin_A2_G, 0);
    Serial.println("Ampel_1_Red&0");
    Serial.println("Ampel_1_Yellow&0");
    Serial.println("Ampel_1_Green&0");
    Serial.println("Ampel_2_Red&0");
    Serial.println("Ampel_2_Yellow&0");
    Serial.println("Ampel_2_Green&0");

    Serial.println("Ende Test Durchlauf");
    delay(500);
}

void SerialEvent() {
    String inString = "";
    bool stringComplete = false;
    //Lese Befehl
    while (Serial.available()) {
        char inChar = (char)Serial.read();
        inString += String(inChar);

        if (inChar == '\n')
        {
            stringComplete = true;
        }
    }
    inString.remove(0, 1);
    // auführen
    if (stringComplete)
    {
        if (inString.equals("Connection") & inString.equals("Connect")) {
            Serial.println("Confirmation");
            Serial.println("Setting_RG=" + String(Value_RG));
            Serial.println("Setting_RG=" + String(Value_RG));
            Serial.println("Setting_Y=" + String(Value_Y));
        }
        else if (inString.equals("Setting_RG")) {
            Value_RG = split(inString, '&', 2).toInt();
            SaveToEEPROM(Adr_V_RG, Value_RG);
        }
        else if (inString.equals("Setting_Y")) {
            Value_Y = split(inString, '&', 2).toInt();
            SaveToEEPROM(Adr_V_Y, Value_Y);
        }
        else if (inString.equals("Setting_RR")) {
            Value_RR = split(inString, '&', 2).toInt();
            SaveToEEPROM(Adr_V_RR, Value_RR);
        }
    }

}

String split(String s, char parser, int index) {
    String rs = "";
    int parserIndex = index;
    int parserCnt = 0;
    int rFromIndex = 0, rToIndex = -1;
    while (index >= parserCnt) {
        rFromIndex = rToIndex + 1;
        rToIndex = s.indexOf(parser, rFromIndex);
        if (index == parserCnt) {
            if (rToIndex == 0 || rToIndex == -1) return "";
            return s.substring(rFromIndex, rToIndex);
        }
        else parserCnt++;
    }
    return rs;
}

void ReadFromEEPROM() {
    Value_RG = EEPROM.read(Adr_V_RG);
    Value_RR = EEPROM.read(Adr_V_RR);
    Value_Y = EEPROM.read(Adr_V_Y);
}

void SaveToEEPROM(int Adr, int Value) {
    EEPROM.put(Adr, Value);
}
