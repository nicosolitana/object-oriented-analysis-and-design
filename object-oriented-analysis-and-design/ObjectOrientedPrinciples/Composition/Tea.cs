namespace object_oriented_analysis_and_design.ObjectOrientedPrinciples.Composition
{
    // When dealing with types of an object,
    // we tend to favor performing inheritance.
    // Like for example, in the code below,
    // there are three kinds of tea which can be
    // with honey, with sugar and with milk.
    // in case, we have another type of tea, we just 
    // create another class and extend it to tea
    // so it would inherit all base functionalities;
    // However, this creates an explosion of types of class tea
    // which is not good.
    class Tea
    { }

    class TeaWithHoney : Tea
    { }

    class TeaWithSugar : Tea
    { }

    class TeaWithMilk : Tea
    { }


    // To improve upon the above code,
    // we will follow the principle: Favor composition over inheritance.
    // Meaning to say, we create distinct classes out of the common
    // difference from the types of tea.
    // For instance, milk, sugar and oney are condiments.
    // Therefore, we can just create a superclass condiments where
    // classes sugar, honey and milk inherits.
    // Then, instead of making tea a superclass, it can just have
    // a property of array of condiments where there's a tea that can
    // contain both milk and sugar, just milk, or any other condiments.
    // With this, class duplication as well as subclasses explosions are avoided.
    class Condiments
    { }
    class Sugar : Condiments
    { }
    class Honey : Condiments
    { }
    class Milk : Condiments
    { }

    class NewTea
    {
        private Condiments[] _condiments;
    }
}
