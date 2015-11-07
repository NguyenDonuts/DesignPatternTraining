public class Jocker : Card, IJocker{
    public Jocker() {

    }

    public void changeStatus(int card_number, int card_type) {
        this.card_number = card_number;
        this.card_type = card_type;
    }

}