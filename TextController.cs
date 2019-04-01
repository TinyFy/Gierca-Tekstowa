using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {
    public Text text;
    int ZMIANA;
    // Start is called before the first frame update
    States myState;
    private enum States { state_entry, state_talkone, state_compliment, state_book, state_weather,
        state_gate, state_window, state_windowlocked, state_pay, state_miracle, state_gatetwo, state_paytwo,
        state_miracletwo, state_friend, state_weird, state_chair, state_sit, state_noattention, state__waiter,
        state_water, state_wine, state_ask, state_smile, state_fun, state_takeabillpay, state_complimenttwo,
        state_share, state_payforyourself, state_shewantstopay, state_agree, state_disagree }

    void state_entry()
    {
        
        text.text = "Znajdujesz się przed wejściem do ekskluzywnej restauracji Ryneczek Lidla, \n" +
            " jesteś tam wraz z dziewczyną, którą poznałeś wczoraj na imprezie w pubie, \n" +
            "problem w tym, że zapomniałeś zarezerwować miejsce w lokalu... \n" +
            "Naciśnij 1, aby zagadać do laski\n" +
            "1. Zagadaj";

        if (Input.GetKeyDown(KeyCode.Alpha1))
        { 
            myState = States.state_talkone;
        }
    }

    void Start() {
        myState = States.state_entry;

    }

    // Update is called once per frame
    void Update()
    {
        if (myState == States.state_entry) { state_entry(); }
        else if (myState == States.state_talkone) { state_talkone(); }
        else if (myState == States.state_agree) { state_agree(); }
        //else if (myState == States.state_book) { state_book(); }
        

        
        //else if (myState = States.state_entry){state_entry(); }

    } 

    private void state_agree()
    {
        text.text = "zgoda text tutaj";
        if (Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.state_agree; }
    }

    private void state_book()
    {
        text.text = "`A kto umarł, ten nie żyje` powiedziałeś.\n" +
            " Serio?! To właśnie jest twój cytat\n " +
            "Chłopie, co ty czytasz?!" +
            " Miałeś szczęście, bo dziewczyna odebrała to\n" +
            "jako jakiś żart, czy coś." +
            "1. Podjedź do bramki";
        if (Input.GetKeyDown(KeyCode.A)) { myState = States.state_gate; }
    }

    private void state_talkone()
    {
        text.text = "Próbujesz wyrzucić z siebie kilka słów, tylko co?\n" +
            "1. Zarzuć cytatem z jakiejś książki\n" +
            "2. Walnij jej komplement\n" +
            "3. A może coś o pogodzie";
        if (Input.GetKeyDown(KeyCode.Alpha1)) {myState = States.state_book; }
        if (Input.GetKeyDown(KeyCode.Alpha2)) { myState = States.state_compliment; }
        if (Input.GetKeyDown(KeyCode.Alpha3)) { myState = States.state_weather; }
    }

    private void state_compliment()
    {
        text.text = "Skomplementowałeś jej piękne oczy\n" +
            " i dziewczyna uśmiechnęła się. Dobry krok stary!\n" +
            "Teraz tylko nie przedobrzyć." +
            "1. Podejdź do bramki";
        if (Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.state_gate; }
    }
    private void state_gate()
    {
        text.text = "Stoisz już przy bramce, teraz tylko pozostało wykombinować co dalej...";
        if (Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.state_gate; }
      
    }
    private void state_weather()
    {
        text.text = "Zwróciłeś uwagę na pogodę,\n" +
            "ale mimo iż była zjawiskowa, (chodzi o pogodę ty dzbanie)\n" +
            "to trochę było to drętwe." +
            "1. Podjedź do bramki";
        if (Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.state_gate; }

    }
    private void state_waiter()
    {
        text.text = "bramka text tutaj";
        if (Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.state_waiter; }

    }
    private void state_noattention()
    {
        text.text = "bramka text tutaj";
        if (Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.state_noattention; }

    }
    private void state_sit()
    {
        text.text = "bramka text tutaj";
        if (Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.state_sit; }

    }
    private void state_chair()
    {
        text.text = "bramka text tutaj";
        if (Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.state_chair; }

    }
    private void state_weird()
    {
        text.text = "bramka text tutaj";
        if (Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.state_weird; }

    }
    private void state_water()
    {
        text.text = "A";
        if (Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.state_water; }

    }
    private void state_ask()
    {
        text.text = "A";
        if (Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.state_ask; }

    }
    private void state_share()
    {
        text.text = "A";
        if (Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.state_share; }

    }
    private void state_smile()
    {
        text.text = "A";
        if (Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.state_smile; }

    }
        }
    private void state_window()
    {
        text.text = "A";
        if (Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.state_window; }

    }
    private void state_windowlocked()
    {
        text.text = "A";
        if (Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.state_smile; }

    }
        private void state_pay()
    {
        text.text = "A";
        if (Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.state_smile; }

    }
        private void state_payforyourself()
    {
        text.text = "A";
        if (Input.GetKeyDown(KeyCode.Alpha1)) { myState = States.state_smile; }

    }







}
