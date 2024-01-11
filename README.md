# Mikrofala

Symulator mikrofalówki. Tylko bardziej. W zasadzie to makrofalówka. Z temperaturą mierzoną w °kC i czasem w ms.

![image](https://github.com/SzymonMucha/Mikrofala/assets/86188861/2f348646-ffbd-4828-a7f5-bc6933c8ad88)

Symulator powstał we współpracy z Adamem Forteckim, który odpowiada za kod, doborem/tworzeniem części audiowizualnej zajmowałem się ja (grafiki przedstawiające licznik Geigera, słoik, kurczaka, rękawice, a także nagranie występujące po ugotowaniu wodoru oraz wszystkie użyte tutaj dźwięki, nie należą do nas i nie rościmy sobie do nich żadnych praw). Gra powstała przy użyciu silnika Unity. 

# Instrukcja

1) Kliknięcie na kurczaka/słoik z wodorem spowoduje umieszczenie go w urządzeniu
2) Najpierw wprowadzamy temperaturę, następnie czas gotowania (czas*temperatura = próg ugotowania):
   	* próg ugotowania < 10 niedogotowany
	* próg ugotowania >= 10 & próg ugotowania < 12 upieczony
	* próg ugotowania >= 12 & próg ugotowania < 16 spalony
	* próg ugotowania >= 16 cień po kurczaku
3) Po wpisaniu każdej wartości klikamy enter 1x, wybierany jest przycisk pod środkowym palcem rękawicy/kursora
4) Następnie klikamy duży prostokątny przycisk pod klawiaturą numeryczną;
5) Po animacji gotowania i otworzeniu się drzwiczek można zjeść produkt klikając na niego
6) Po ugotowaniu i "zjedzeniu" słoika z wodorem odtworzy się animacja, po której trzeba opuścić   grę skrótem ALT+F4
   (tak jak za każdym razem, gdy chcemy opuścić grę)
7) Po konsumpcji kurczaka można grać dalej 
