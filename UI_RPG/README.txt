Savā projektā es izmantoju objektorientētās programmēšanas (OOP) pamatprincipus, lai uzlabotu koda struktūru, uzlabotu tā lasāmību un atvieglotu tā turpmāku paplašināšanu un uzturēšanu. Galvenie OOP principi, ko es izmantoju, ir šādi:

Mantojums
Mantošana ļauj izveidot jaunas klases, pamatojoties uz esošajām klasēm. Savā projektā es izmantoju mantošanu, lai izveidotu dažādus tēlu tipus (piemēram, Spēlētājs, Ienaidnieks), kas manto no bāzes tēlu klases. Tas ļauj atkārtoti izmantot visiem personāžiem kopīgu loģiku, piemēram, bojājumu apstrādi vai efektu piemērošanu, un pievienot katram personāžu tipam unikālas funkcijas, nedublējot kodu.

Enkapsulācija
Enkapsulācija ļauj paslēpt objektu iekšējo implementāciju un nodrošināt piekļuvi datiem, izmantojot publiskās metodes. Savā projektā es slēpju tādas personāža implementācijas detaļas kā veselība vai aktīvie ieroči un piekļūstu šiem datiem, izmantojot publiskās īpašības un metodes.

Polimorfisms
Polimorfisms ļauj dažādu tipu objektiem izsaukt vienu un to pašu metodes nosaukumu, bet ar atšķirīgu implementāciju. Manā projektā tas tiek izmantots, lai tādas metodes kā GetHit() vai Shout() varētu izsaukt gan spēlētājiem, gan ienaidniekiem, lai gan to implementācija ir atšķirīga.

Abstrakcija
Abstrakcija ļauj paslēpt sarežģītas implementācijas detaļas un nodrošināt tikai tās metodes un īpašības, kuras nepieciešams izmantot. Manā projektā abstrakcija ir īstenota ar tēla bāzes klases palīdzību, kas satur tādas kopīgas metodes kā bojājumu uzņemšana un veselības atjaunošana, un ar saskarņu palīdzību, kas nosaka tādu objektu kā ieroči uzvedību.

es realizēju šos papilduzdevumus:

3 dažādi pretinieki ar atšķirīgiem uzbrukumiem

3 ieroču tipi, starp ko spēlētājs var izvēlēties