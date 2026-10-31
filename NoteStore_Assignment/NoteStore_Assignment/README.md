# C# File Handling – Complete Notes
### Somali & Easy English Explanation

---

## 1. What is File Handling?

**File Handling** waa habka uu program-ku u sameeyo, u furo, u akhriyo, wax ugu qoro, wax ugu daro, una tirtiro files.

A file wuxuu kaydin karaa xog si dib loogu isticmaalo maalmo ama waqti dambe, xitaa marka program-ka la xiro.

**Example:**
- `students.txt` – wuxuu kaydin karaa magacyada ardayda.
- `notes.txt` – wuxuu kaydin karaa qoraallo.
- `report.doc` – wuxuu kaydin karaa document, laakiin habka TXT ee casharkan si toos ah uma maamulo qaabka DOC.

> **Important:** `StreamWriter` iyo `StreamReader` waxay si fudud ula shaqeeyaan text files sida `.txt`. DOC/DOCX waa document formats leh qaab-dhismeed gaar ah; laguma maamulo sidii plain text file haddii la doonayo in formatting-ka la ilaaliyo.

### Why do we use File Handling?
1. To save data for later use – xogta mustaqbalka loo kaydiyo.
2. To read saved information – xog hore loo kaydiyey loo akhriyo.
3. To update files – xog cusub loogu daro.
4. To delete unnecessary files – files aan loo baahnayn loo tirtiro.

---

## 2. The Two Important Classes

C# File Handling casharkan wuxuu si gaar ah u isticmaalaa laba class:

### A. StreamWriter Class

`StreamWriter` waxaa loo isticmaalaa **writing** iyo **appending** text gudaha file.

- **Writing:** xog ayuu file ku qoraa.
- **Appending:** xog cusub ayuu ku daraa dhammaadka file-ka.




Sharaxaad:
- `StreamWriter` – class-ka wax ku qora file.
- `sw` – magaca object-ka.
- `new StreamWriter(...)` – wuxuu furaa ama abuuraa file si wax loogu qoro.
- `WriteLine()` – wuxuu qoraa qoraalka kadibna wuxuu u gudbaa line cusub.
- `Close()` – wuxuu xiraa file-ka.

### B. StreamReader Class

`StreamReader` waxaa loo isticmaalaa **reading** – akhrinta xogta ku jirta file.



Sharaxaad:
- `StreamReader` – class-ka wax ka akhriya file.
- `sr` – magaca object-ka.
- `ReadToEnd()` – wuxuu akhriyaa dhammaan qoraalka file-ka.
- `Console.WriteLine()` – wuxuu natiijada soo bandhigaa.
- `Close()` – wuxuu xiraa file-ka.

---

## 3. Every File Has Three Main Processes

File Handling wuxuu leeyahay saddex marxaladood:

### Step 1: Open the File

**Open = Creating a connection between the file and the program.**

Af-Soomaali: Waa in program-ku furo file-ka si uu ula shaqeeyo.

Examples:
- `File.CreateText()` – abuura file cusub oo u fura writing.
- `File.AppendText()` – fura file si xog loogu daro dhammaadkiisa.
- `File.OpenText()` – fura file si loo akhriyo.

### Step 2: Process the File

**Process = Performing an operation on the file.**

Af-Soomaali: Waa hawsha file-ka lagu qabanayo.

Waxaa ka mid ah:
- Writing – qoraal gelin.
- Reading – xog akhrin.
- Appending – xog cusub ku darid.
- Deleting – file tirtirid.

### Step 3: Close the File

**Close = Disconnecting the file from the program.**

Af-Soomaali: Marka shaqada la dhammeeyo, file-ka waa in la xiraa si resources-ka loo sii daayo, xogtana si sax ah loo kaydiyo.


**Recommended method: `using`**

`using` wuxuu file-ka si automatic ah u xiraa marka block-ku dhammaado, xitaa haddii exception dhaco.


---

## 4. OPEN THE FILE – Creating or Opening a File

### A. Create a New File – `File.CreateText()`

Waxaa loo isticmaalaa in la abuuro text file cusub.




**Explanation:**
- `File` – class-ka file operations.
- `CreateText()` – abuura file qoraal ah.
- `StreamWriter` – waxaa loo isticmaalaa in file-ka wax lagu qoro.

> **Important:** Haddii file hore u jiray oo isla magacaas leh, `CreateText()` wuxuu tirtirayaa content-kii hore kadibna file-ka dib ayuu u abuuraa. Ka taxaddar xogta muhiimka ah.

### B. Append a File – `File.AppendText()`

Waxaa loo isticmaalaa in xog cusub lagu daro dhammaadka file hore.




**Explanation:**
- `AppendText()` – wuxuu file-ka u furaa in xog lagu daro.
- Xogtii hore ma tirtirayo.
- `WriteLine()` – wuxuu qoraalka cusub geliyaa line cusub.

Haddii file-ku uusan jirin, `AppendText()` wuu abuuri karaa.

### C. Read a File – `File.OpenText()`

Waxaa loo isticmaalaa in file loo furo reading.


**Explanation:**
- `OpenText()` – wuxuu file-ka u furaa reading.
- `StreamReader` – wuxuu akhriyaa xogta.
- `ReadToEnd()` – wuxuu akhriyaa dhammaan qoraalka.

---

## 5. PROCESS THE FILE

### 5.1 Writing a File – `Write()` and `WriteLine()`

Writing waxaa loo isticmaalaa in qoraal lagu kaydiyo file.

#### `Write()`

Wuxuu qoraa text, laakiin si automatic ah uma bilaabo line cusub.


File content:

```text
Hello Student
```

#### `WriteLine()`

Wuxuu qoraa text kadibna wuxuu bilaabaa line cusub.



File content:

```text
First line
Second line
```

**Difference:**
- `Write()` – qoraalka wuxuu ku sii wadaa isla line-ka.
- `WriteLine()` – qoraalka kadib wuxuu u gudbaa line cusub.

### 5.2 Reading a File

C# wuxuu leeyahay dhowr hab oo file loo akhriyo.

#### A. `Read()`

`Read()` wuxuu akhriyaa hal character markiiba. Wuxuu soo celiyaa integer-ka character-ka, wuxuuna soo celiyaa `-1` marka dhammaadka file-ka la gaaro.




Sharaxaad:
- `sr.Read()` – wuxuu akhriyaa hal character.
- `while` – wuxuu ku celceliyaa inta characters ay jiraan.
- `-1` – wuxuu tilmaamayaa in dhammaadka file-ka la gaaray.
- `(char)character` – integer-ka wuxuu u beddelaa character.

#### B. `ReadLine()`

`ReadLine()` wuxuu akhriyaa hal line markiiba.




Sharaxaad:
- `ReadLine()` – wuxuu akhriyaa hal sadar.
- `line` – wuxuu kaydiyaa sadarka la akhriyey.
- `null` – wuxuu tilmaamayaa in line kale uusan jirin.
- `while` – wuxuu akhriyaa dhammaan lines-ka ilaa dhammaadka file-ka.

#### C. `ReadToEnd()`

`ReadToEnd()` wuxuu akhriyaa dhammaan qoraalka file-ka hal mar, adigoon loop qorin.




Sharaxaad:
- Wuxuu akhriyaa dhammaan content-ka.
- Wuxuu ku kaydiyaa variable-ka `data`.
- Loop looma baahna.
- Waa hab fudud marka aad rabto dhammaan qoraalka.

#### D. `File.ReadAllText()`

`File.ReadAllText()` wuxuu akhriyaa dhammaan qoraalka file-ka isagoo aan u baahnayn inaad adigu samaysato `StreamReader`.




Sharaxaad:
- `File.ReadAllText()` – wuxuu file-ka oo dhan u akhriyaa string.
- `data` – wuxuu kaydiyaa qoraalka oo dhan.
- Adigu ma qoreysid loop.
- Adigu ma qoreysid `Close()`; method-ku wuxuu maareeyaa furista iyo xirista file-ka.

> **Correction:** `ReadAllText()` ma aha method ka tirsan `String` class. Waa method ka tirsan `System.IO.File` class.

### Reading Methods – Quick Comparison

| Method | Waxa uu akhriyo | Loop |
|---|---|---|
| `Read()` | Hal character | Badanaa haa |
| `ReadLine()` | Hal line | Badanaa haa |
| `ReadToEnd()` | Dhammaan file-ka | Maya |
| `File.ReadAllText()` | Dhammaan file-ka | Maya |

---

## 6. EndOfStream Property

`EndOfStream` waa property ka tirsan `StreamReader`.

Waxay hubisaa in akhristuhu gaaray dhammaadka file-ka iyo in kale.

Waxay soo celisaa laba qiime:

- `True` – dhammaadka file-ka waa la gaaray.
- `False` – weli xog ayaa harsan.




Sharaxaad:
- `sr.EndOfStream` – wuxuu hubiyaa in dhammaadka la gaaray.
- `!` – macnaheedu waa NOT.
- `!sr.EndOfStream` – loop-ku wuu soconayaa inta aan dhammaadka la gaarin.
- `ReadLine()` – wuxuu akhriyaa line kasta.

**Remember:** `EndOfStream` waa property, ma aha method; sidaas darteed parentheses `()` lama raaciyo.

---

## 7. Delete a File – `File.Delete()`

`File.Delete()` waxaa loo isticmaalaa in file la tirtiro.




Sharaxaad:
- `File.Exists()` – wuxuu hubiyaa in file-ku jiro.
- `File.Delete()` – wuxuu tirtiraa file-ka.
- `if` – wuxuu hubiyaa xaaladda.
- `else` – wuxuu shaqeeyaa haddii file-ku uusan jirin.

**Important:** Delete waa hawl tirtiraysa file-ka. Hubi magaca iyo meesha file-ku yaallo ka hor intaadan tirtirin.

---

## 8. Append a File – `Write()` and `WriteLine()`

Append wuxuu xog cusub ku daraa dhammaadka file-ka isaga oo ilaalinaya xogtii hore.



Haddii file-ku hore u lahaa:

```text
Hello Student
```

Kadib Append, wuxuu noqonayaa:

```text
Hello Student
New Information
```

**Remember:**
- `File.CreateText()` – wuxuu abuuraa file; haddii uu jiro, content-kii hore wuu beddelaa.
- `File.AppendText()` – wuxuu ku daraa xog cusub dhammaadka file-ka.

---

## 9. Close the File – `Close()`

`Close()` waxaa loo isticmaalaa in la xiro StreamWriter ama StreamReader marka hawsha la dhammeeyo.



## 13. Final Summary

Remember these three main ideas:

**1. OPEN**
- `CreateText()`
- `AppendText()`
- `OpenText()`

**2. PROCESS**
- Writing: `Write()`, `WriteLine()`
- Reading: `Read()`, `ReadLine()`, `ReadToEnd()`, `ReadAllText()`
- Appending: `AppendText()`
- Deleting: `File.Delete()`

**3. CLOSE**
- `Close()`
- Or use `using` for automatic closing.

**The most important rule:**
- `StreamWriter` = Write / Append.
- `StreamReader` = Read.
- `File` = Create / Append / Open / Exists / Delete / ReadAllText.

---

## 10. Sida Loo Isticmaalo Barnaamijka File Management System



### Qaybaha ku jira Form-ka

- **File Name:** Halkaan geli magaca file-ka ama meesha uu ku kaydsan yahay.
- **Enter Text:** Halkaan ku qor qoraalka aad rabto inaad file-ka geliso.
- **File Content:** Halkaan ayaa lagu soo bandhigayaa qoraalka laga akhriyo file-ka.

## Sida loo isticmaalo Buttons-ka

### 1. Create File

Button-kan wuxuu sameeyaa file cusub.

**Sida loo isticmaalo:**
1. Ku qor magaca file-ka qaybta File Name, tusaale ahaan `test.txt`.
2. Riix Create File.
3. Haddii file-ka la sameeyo, fariin ayaa kuu sheegi doonta inuu guulaystay.

Haddii aad geliso magac keliya oo aan lahayn meel kaydin, barnaamijku wuxuu u baahan yahay meel uu file-ka ku abuuro. Dooro meel aad fasax u haysato, sida Documents.

### 2. Create New File Path

Button-kan wuxuu kuu oggolaanayaa inaad doorato folder-ka uu file-ku ku kaydsanaanayo.

**Sida loo isticmaalo:**
1. Riix Create New File Path.
2. Dooro folder-ka aad rabto.
3. Riix OK.
4. Meesha file-ka lagu kaydinayo ayaa ka muuqanaysa File Name.

Button-kan wuxuu doortaa meesha kaydinta; file-ka laftiisa ma abuuro ilaa aad riixdo Create File ama aad isticmaasho Create New File Name.

### 3. Create New File Name

Button-kan wuxuu kuu furayaa daaqad aad ku dooranayso magaca file-ka iyo meesha lagu kaydinayo.

**Sida loo isticmaalo:**
1. Riix Create New File Name.
2. Dooro folder-ka aad rabto.
3. Geli magaca file-ka, tusaale `students.txt`.
4. Riix Save.
5. File-ka waa la abuuri doonaa, magaciisa iyo meesha uu yaallo-na waxay ka muuqanayaan File Name.

### 4. Write File

Button-kan wuxuu qoraalka ku jira Enter Text ku kaydiyaa file-ka la doortay.

**Sida loo isticmaalo:**
1. Hubi in File Name uu leeyahay magaca ama meesha file-ku yaallo.
2. Ku qor qoraalka Enter Text.
3. Riix Write File.
4. Qoraalka waxaa lagu kaydinayaa file-ka.

**Fiiro gaar ah:** Write File wuxuu beddelaa qoraalkii hore ee file-ka. Haddii aad rabto inaad qoraal cusub ku darto adigoon kii hore tirtirin, isticmaal Append File.

### 5. Read File

Button-kan wuxuu akhriyaa dhammaan qoraalka ku jira file-ka, wuxuuna ku soo bandhigaa File Content.

**Sida loo isticmaalo:**
1. Geli ama dooro file hore loo sameeyay.
2. Riix Read File.
3. Qoraalka file-ka wuxuu ka muuqanayaa File Content.

### 6. Read Line

Button-kan wuxuu file-ka u akhriyaa sadar-sadar. Wuxuu isticmaalaa `ReadLine()`.

**Sida loo isticmaalo:**
1. Dooro file qoraal ku jiro.
2. Riix Read Line.
3. Sadar kasta waxaa lagu soo bandhigayaa File Content.

Tusaale ahaan, haddii file-ku leeyahay saddex sadar, barnaamijku wuxuu akhrinayaa sadarka koowaad, kan labaad, kadibna kan saddexaad ilaa uu dhammaadka gaaro.

### 7. Read All Text

Button-kan wuxuu hal mar akhriyaa dhammaan qoraalka file-ka. Wuxuu isticmaalaa `File.ReadAllText()`.

**Sida loo isticmaalo:**
1. Dooro file qoraal ku jiro.
2. Riix Read All Text.
3. Dhammaan qoraalka file-ka hal mar ayuu ka soo muuqanayaa File Content.

### 8. Read Function

Button-kan wuxuu akhriyaa hal xaraf markiiba. Wuxuu isticmaalaa `Read()`.

**Sida loo isticmaalo:**
1. Dooro file qoraal ku jiro.
2. Riix Read Function.
3. Xarfaha file-ka ayuu mid mid u akhriyaa, kadibna qoraalka ayuu ku soo bandhigayaa File Content.
4. Marka uu dhammeeyo, fariin ayaa kuu sheegaysa tirada xarfaha la akhriyey.

### 9. Append File

Button-kan wuxuu qoraal cusub ku daraa dhammaadka file-ka, isaga oo ilaalinaya qoraalkii hore.

**Sida loo isticmaalo:**
1. Dooro file hore u jiray.
2. Ku qor qoraalka cusub Enter Text.
3. Riix Append File.
4. Qoraalka cusub wuxuu ku darsamayaa dhammaadka qoraalkii hore.

### 10. Delete File

Button-kan wuxuu tirtiraa file-ka la doortay.

**Sida loo isticmaalo:**
1. Hubi in File Name uu yahay file-ka aad rabto inaad tirtirto.
2. Riix Delete File.
3. Waxaa lagu weydiinayaa inaad xaqiijiso tirtirista.
4. Haddii aad doorato Yes, file-ka waa la tirtirayaa. Haddii aad doorato No, waxba lama tirtirayo.

**Fiiro gaar ah:** File la tirtiro dib loogama soo celin karo barnaamijkan. Hubi file-ka ka hor intaadan tirtirin.

### 11. Clear

Button-kan wuxuu nadiifiyaa saddexda meelood ee qoraalka: File Name, Enter Text iyo File Content.

**Sida loo isticmaalo:** Riix Clear marka aad rabto inaad meelaha qoraalka ka bilowdo mar kale. Button-kan ma tirtiro file-ka ku kaydsan kombiyuutarka.

## Tusaale: Sida barnaamijka loo tijaabiyo

1. Riix Create New File Name.
2. Dooro Documents, kadibna magaca u bixi `test.txt` oo riix Save.
3. Enter Text ku qor:

   ```text
   My name is Ahmed.
   I am a university student.
   I study Computer Science.
   I like programming.
   ```

4. Riix Write File si qoraalka loo kaydiyo.
5. Riix Read Line si aad u aragto sida sadar-sadar loo akhriyo.
6. Riix Read All Text si qoraalka oo dhan hal mar loo akhriyo.
7. Riix Read Function si xarfaha mid mid loo akhriyo.
8. Haddii aad rabto qoraal kale inaad ku darto, geli Enter Text kadib riix Append File.
9. Riix Read File si aad u hubiso qoraalka cusub.
10. Riix Clear si aad u nadiifiso meelaha qoraalka.

## Xusuusin

- Marka hore samee file ama dooro file hore u jiray.
- Read Buttons-ku waxay akhriyaan file-ka ku qoran File Name; haddii saddexduba isla file-ka akhriyaan, qoraalka ay soo bandhigayaan waa isku mid, balse habka akhrisku wuu kala duwan yahay.
- `ReadLine()` wuxuu akhriyaa sadar-sadar.
- `Read()` wuxuu akhriyaa xaraf-xaraf.
- `ReadAllText()` wuxuu akhriyaa qoraalka oo dhan hal mar.
- `Write File` wuxuu beddelaa qoraalkii hore, halka `Append File` uu qoraal cusub ku daro dhammaadka.
