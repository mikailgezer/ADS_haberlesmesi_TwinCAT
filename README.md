# ADS_haberlesmesi_TwinCAT


PLC codes:

PROGRAM MAIN VAR

nAnalogInput	AT%I*	: INT;
readWriteValue: REAL;

threshold: REAL := 1.5;
isAboveThreshold: BOOL;

bDigitalInput1	AT%I*	: BOOL;
digitalInput2:	BOOL;
bDigitalOutput2	AT%Q*	: BOOL;
bDigitalOutput1	AT%Q*	: BOOL;

nInput	AT%I*	: INT;
nOutput AT%Q*	: INT;

akim_Output	: REAL;	

nGerilim_output  AT%Q*	: INT;
gerilim_Output 	: REAL;

bDigitalInput3		AT%I*	: BOOL;
bDigitalOutput3		AT%Q*	: BOOL;
END_VAR

// Örnek 1 
// DigitalInput2  isimli(linkleme işlemi yapılmamış button) buttona basarak bDigitalOutput1 aktif etme.

IF digitalInput2 THEN 
bDigitalOutput1 := TRUE; 
ELSE bDigitalOutput1 := FALSE; END_IF


// Örnek 2 
// Scada ekranındaki textbox a girilen değer belli bir değerin (1.5)üzerindeyse DigitalOutput2 çıkışını aktif etme.

IF readWriteValue > threshold THEN 
bDigitalOutput2 := TRUE; 
ELSE 
bDigitalOutput2 := FALSE; END_IF;


// Örnek 3 
// TwinCAT programına kullanıcı tarafından yazılan akım değeri (akim_Output) Bechoff PLC nin (EL4028(4-20 mA analogOutput)) da görünür.

nOutput := REAL_TO_INT(2048 * akim_Output - 8192);


// Örnek 4 
// TwinCAT programına kullanıcı tarafından yazılan gerilim değeri (gerilim_Output) Bechoff PLC nin (EL4008(0-10 V analogOutput)) da görünür.

nGerilim_output := REAL_TO_INT(3277 * gerilim_Output);

