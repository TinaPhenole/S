Sveriges Förenade Filmföreningar
**Läs instruktionerna noggrant! Se även checklistan i slutet!**

Både funktionskrav samt rapport skall lämnas in. Rapporten skrivs i filen Rapport.md. Mer instruktioner angånde rapporten finns i filen i sig.
Uppdraget
I detta uppdrag så ska ni jobba för Sveriges Förenade Filmstudios (SFF) och utveckla ett WebAPI samt en hemsida där SFF kan se utbudet av filmer samt registrera filmutlån till anslutna föreningar. De vill också kunna registrera och lägga in nya föreningar.

SFF fungerar på så sätt att filmintresserade personer bildar föreningar som sedan blir medlemmar i SFF, som är förbundet för hela Sverige. SFF har rätt från filmbolagen att låna ut ett visst antal exemplar av olika filmer till dom lokala föreningarna som sedan visar dem på exempelvis kulturbiografer i sina städer. Förut skedde detta via blanketter och dyr transport av fysiska filmrullar - men idag sker detta såklart mestadels digitalt.

Det finns dock filmer som inte hunnit blivit digitaliserade ännu och de måste skickas med post och finns bara i ett visst antal! De digitala filmerna har vanligtvis också ett max antal som får vara utlånade samtidigt.

SFF önskar nu att du tar fram en lösning för att hålla koll på vilka filmer som finns tillgängliga för föreningarna att låna!

Förutsättningar
API:et och klientgränssnittet ska bara användas av administratörer som jobbar på SFFs huvudkontor i Stockholm. De har personligen kontakt med olika filmföreningar och vill använda programmet för att uppdatera den nuvarande statusen på de olika filmerna, hålla koll på vilka som lånat vad och så vidare.

- Applikationen skall först och främst bestå av ett fungerande WebAPI, så att SFF lätt kan integrera informationen med deras andra existerande system.

- De vill ha ett webbgränssnitt där de skall kunna se status på filmerna, men gärna också kunna administrera allt. Detta webbgränssnitt kan tänkas köras internt, så det finns i nuläget inget krav på autentisering. **Designen på webbsidan är inte viktig i nuläget, bara funktionen**. En hipp webbsdesigner från San Fransisco kommer att hyras in så småningom, om budgeten tillåter.

- MVC, RazorPages eller Blazor kan användas för webbsidan.
