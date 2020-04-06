# phonebook
Proiect Final
1. Date generale
Să se creeze o aplicație “Agenda telefonică” cu următoarele caracteristici:
- Aplicație windows desktop application
- Va avea 2 ferestre: frmMainWindow si frmSearchWindow. FrmMainWindow este cea care se va afișa atunci când aplicația este rulată.
1.1. Design
Fereastra frmMainWindow trebuie să conțină meniu, buton de încărcare date, salvare date, datagridview
Meniul va conține 2 opțiuni principale: File și Edit
Meniul File va conține 3 opțiuni: Serializare informații, Preferințe și Exit.
Meniul Edit va conține opțiunea Caută persoană.
Butonul de încarcare date: butonul care va încarca din baza de date informații și le va afișa în datagridview. Este tot timpul activ.
Butonul salvare date: butonul care va salva ceea ce se află în datagridview în baza de date. Este tot timpul activ.
Datagridview va afișa informațiile din tabela Abonați din baza de date.
Obs:
- nu sunt admise erori de tip excepție netratate: codul care va trata operațiuni în baza de date, scrierea în fișiere, etc
- fiecare obiect (meniu, buton, etc) va avea un nume semnificativ.
1.2. Dinamica ecranului
Rulare aplicație:
Atunci când aplicația este rulată, fereastra frmMainWindow este afișată.
La afișarea ferestrei pe ecran, se vor face următoarele:
 Se construiesc coloanele controlului datagridview
 Controlul datagridview va permite ca utilizatorul să poată adăuga linii în el.
 La interogare în baza de date se extrag toate înregistrările din tabela Abonați. Dacă se gasește cel puțin o înregistrare, atunci controlul datagridview este populat cu linii. Altfel rămâne doar cu coloane.
Dacă utilizatorul dă click pe butonul Load Data:
 Se va face o interogare în baza de date, tabela Abonati.
 Dacă se găsesc înregistrări, datagridview-ul este populat cu liniiile din tabelă.
 Dacă nu se găsesc înregistrări, datagridview-ul este afișat fără linii și se afișează mesajul: Nici un abonat găsit în bază.
Dacă utilizatorul dă click pe butonul SaveData:
 Este folosit pentru a salva în baza de date, tabela Abonati, modificările făcute în controlul datagriview.
 Atenție: în controlul datagridview userul poate să: adauge înregistrări, modifice înregistrări, șteargă linii. Deci, în baza de date se pot face: INSERT-uri, UPDATE-uri, DELETE-uri.
 Dacă operația este făcută cu success în baza de date, atunci mesajul “Date salvate cu succes în baza de date” este afișat. In caz de eroare, un mesaj corespunzător este afișat utilizatorului.
Controlul DataGridView este construit:
 Coloanele sunt construite o singură data, de preferat în functia care tratează evenimentul FrmMainWindow_Load
 De fiecare data când este nevoie să se afișeze liniile acestui control cu informații din baza de date (la încărcarea ferestrei, la click pe butonul Load Data, etc), înainte de a face acesta, liniile existente se vor șterge
 Fiecare celulă este editabilă. Utilizatorul poate da dublu click într-o celulă și poate modifica conținutul celulei, poate adăuga linii, sau poate șterge o linie întreagă din control.
Meniul Serializare date:
 Realizează serializarea datelor din DataGridView într-un fișier pe disc, serializare de tip XML
 Dacă nici o linie nu este în datagridview, atunci se afișează un mesaj de eroare: Nimic de serializat.
 Dacă există cel puțin o linie în datagridview, atunci:
o La alegerea opțiunii, o nouă fereastră se va deschide. Fereastra este de tipul SaveFileDialog. Permite salvarea fișierului în care se va face serializarea obiectelor.
o Numele fișierului în care se vor serialize datele va fi “Abonati_’timestamp’.xml”, unde ‘timestamp’ este de forma “YYYYMMDDHHmmSS”, adica:
 YYYY = anul current, format din 4 cifre
 MM = luna curentă, 2 cifre
 DD = ziua curentă, 2 cifre
 HH = ora curentă, în format 24h
 mm = minutul orei curente, 2 cifre
 SS = secunda orei curente, 2 cifre.
Meniul Preferinte:
 Prin alegerea acestui meniu se poate permite schimbare fontului pentru grid si butoane, schimbarea culorii ferestrei
Meniul Exit:
 Această opțiune va închide aplicația, cu un mesaj de confirmare: “Sunteti sigur ca doriti sa iesiti? (Yes/No)”. Dacă userul alege No, mesajul este închis și nimic nu se întâmplă. Dacă userul alege Yes, aplicația se închide.
Controlul SaveDialog:
 Trebuie să setați
o titlul ferestrei Save: Salvare fișier serializare;
o filtrul pentru tipul de fișier;
o folderul inițial propus de fereastra save să fie folderul exe al aplicației
o numele implicit al fișierului.
Meniul Cautare persoana:
 Fereastra nouă care conține: un text-box, un buton si un datagridview.
 Utilizatorul introduce un cuvânt în textbox.
 La click pe buton, se face o căutare în baza de date.
 Informațiile sunt întoarse în datagridview. Acesta nu este editabil
