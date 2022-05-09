# Funktionskrav API för Godkänt (9 av 11 krävs)

- Alla endpoints ska ta emot eller returnera JSON-data

  I API:et ska resursen **film** finnas:

- Det ska gå att lägga till en ny fysisk eller digital film till databasen

- Det ska gå att ändra hur många studios som kan låna filmen samtidigt

- Det ska gå att markera att en film är utlånad till en filmstudio (man får inte låna ut den mer än filmen finns tillgänglig (max-antal samtidiga utlåningar)

- Det ska gå att ändra så att filmen inte längre är utlånad till en viss filmstudio (lämna tillbaka)

  En annan resurs som ska finnas är **filmförening**:

- Det ska gå att registrera en ny filmförening

- Det ska gå att ta bort en filmförening

- Det ska gå att byta namn, och ort på en filmförening

- Via API:et ska man kunna få fram vilka filmer som en viss förening har lånat [] - titta på att retunera en lista med filmer som förenings id:et har == movie id

  När filmföreningar visat filmerna rapporterar de in ett betyg och en kort recension på filmen:

- Det ska gå att skapa en ny recension till en viss film.

- En filmförening skall endast kunna recensera en film en gång, inte ge samma film flera recensioner.

- Det ska också gå att rapportera in ett betyg mellan 1 och 5 till en viss film. Det är viktigt att komma ihåg vilken studio som gav betyget för vilken film.

Funktionskrav Webbsidan för Godkänt (5 av 9 krävs)

- Det ska gå att se alla filmerna presenterade i en lista
- Det skall gå att få upp detaljer om en film om man klickar på den
- Det skall gå att låna ut en film till en viss förening
- Det skall gå att lämna tillbaka en film som en förening lånat
- Det ska gå att se hur många tillgängliga licenser/utlån som finns tillgängliga per film
- Det skall gå att lägga till filmer
- Det ska gå att se alla föreningar presenterade i en lista
- Det skall gå att lägga till/ta bort filmföreningar
- Det skall gå att se vilka filmer en filmförening har lånat

Krav för Väl Godkänt (3 av 6 krävs)

- Applikationen har en bra och tydlig uppdelning i olika ansvarsområden, antingen genom kataloger och namespaces eller genom uppdelning i olika separata projekt.

  WebAPI

- API:t kräver autentisering för att kunna användas (Valfri metod)

  Webbsidan

- Det skall gå att sätta ett återlämningsdatum på en film när den lånas ut, så att det på webbsidan går att se vilka föreningar som är sena med sina återlämningar.

- Det skall gå att se medelbetyg och vilka recensioner en film fått

- En publik del som vem som helst kan titta på för att se vilka filmer som finns vore toppen! Kanske kan det motivera fler att starta en filmförening? Detta kräver en inloggningslösen för administratorerna så resten av siten bara är tillgänglig för dem! Det var Stefan som kom på det här på fikat igår! Så det vill vi ha.

- Det skall gå att lägga till en bild till varje film

Tips

- Läs kravspecen noga och skriv en egen Feature-lista i stil med “Lägg till ny film”, “Låna film” osv.
- **Angrip projektet lugnt och metodiskt! Gör inte allt på en och samma gång!**
- Läs kravspecen och analysera vilka objekt du kommer behöva. Minns våra tidigare övningar där vi analyserade vilka substantiv och verb som fanns med i beskrivningarna.
- Notera att det inte måste gå att ta bort filmer, eller ändra deras detaljer (Men det är ok om du implementerar det!)
- Det är ok att ni skapar extra resurser och klasser än de som finns beskrivna här, men detta är nuvarande minimumkrav från SFF i detta projekt.
- Innan alla objekt är klara och specificerade är det smidigt att använda en InMemory-databas, men använd sen SqLite som datalagring (eller annan lokal databas).
- Tänk på att kunden är en ovan beställare av datasystem. Kraven kan vara lite otydligt formulerade Det går att ställa öppna frågor i Fråge-kanalen på Discord.

* Fokusera inte för mkt på exakta formuleringar i kravspecen, exempelvis "Det ska gå att markera att en film är utlånad till en filmstudio". Det är funktionaliteten med utlåning som är det viktiga, inte att det just är någon form av markering det har att göra med. Ibland kan en kundformulerad spec vara skriven på ett sätt som inte använder sig av de ord vi vanligtvis använder inom programmering för att beskriva saker, så då är det bra att fundera på vad är det egentligen de vill åt för funktionalitet.

Checklista för inlämning

- Jag har tagit bort onödig/oanvänd kod

- Jag har tagit bort onödiga kommentarer

- Jag har formaterat min kod fint

- Jag har skrivit rapporten

- Jag har checkat av vilka funktionskrav jag anser att jag klarat

  Exempel:

Alla endpoints ska ta emot eller returnera JSON-data
I API:et ska resursen **film** finnas:
Det ska gå att lägga till en ny film
Det ska gå att ändra hur många studios som kan låna filmen samtidigt
