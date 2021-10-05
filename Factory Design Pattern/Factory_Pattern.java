
interface Aniaml {
    void body();
}

class cow implements Aniaml {

    @Override
    public void body() {
        System.out.println("Hello from cow");
    }

}

class goat implements Aniaml {

    @Override
    public void body() {
        System.out.println("Hello from goat");

    }

}

class sheep implements Aniaml {

    @Override
    public void body() {
        System.out.println("Hello from sheep");

    }

}

class NotAnimal implements Aniaml {

    @Override
    public void body() {
        System.out.println("Not animal");

    }

}

class AniamlFactory {
    public static Aniaml getAniaml(String name) {
        switch (name) {
            case "cow":
                return new cow();
            case "goat":
                return new goat();
            case "sheep":
                return new sheep();
            default:
                return new NotAnimal();
        }
    }
}

/**
 * Factory Pattern
 */
public class Factory_Pattern {
    public static void main(String[] args) {

        AniamlFactory.getAniaml("cow").body();
        AniamlFactory.getAniaml("goat").body();
        AniamlFactory.getAniaml("sheep").body();
        AniamlFactory.getAniaml("aaa").body();
    }
}