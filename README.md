# GarageKata
---
## Garage
Scriviamo un’applicazione per la gestione di un garage pubblico.
Il garage ha al massimo 10 posti, ognuno dei quali è identificato da un numero (a
partire da zero) e, per motivi di capienza, può ospitare soltanto automobili, furgoni e
motociclette.
Il garage ha a disposizione 3 funzionalità:
- E' possibile parcheggiare un veicolo rendendo noto il parcheggio occupato.
- E' possibile estrarre dal garage il veicolo che occupa un determinato posto.
- Stampa della situazione corrente dei posti nel garage: stampare per ogni posto
tutte le informazioni disponibili sul veicolo che lo sta occupando.

### Note
| Automobili |  Furgone   |    Moto    |
|------------|------------|------------|
|    Brand   |    Brand   |   Brand    |
|     AM     |     AM     |    AM      |
| Nr. Porte  |  Capacity  |    Tipo    |
|            |            |   Tempi    |
|------------|------------|------------|

### DOMANDE
- Che differenza c'è ad avere Print di MotorVehicle virtual o non virtual?
- Togliere Print dai figli, e aggiungere un metodo abstract PrintDetails su MotorVehicle
- Posso rendere Car sealed? E MotorVehicle?
- cosa succede a rendere la classe MotorVehicle internal/protected/private?
- cosa succede a rendere il costruttore di MotorVehicle internal/protected/private?
- Come si comporta un'istanza di MotorVehicle abstract?
- Rimuovere abstract da MotorVehicle e fare in modo che il progetto funzioni lo stesso
- Far diventare MotorVehicle un'interfaccia
- Aggiungere un metodo statico in Car che incrementi un valore statico in MotorVehicle
