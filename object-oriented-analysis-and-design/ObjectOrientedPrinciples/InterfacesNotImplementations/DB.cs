namespace object_oriented_analysis_and_design.ObjectOrientedPrinciples.InterfacesNotImplementations
{

    abstract class DB
    {
        public abstract void select();
        public abstract void update();
        public abstract void delete();
    }

    class DevelopmentDB : DB
    {
        public override void select() { }
        public override void update() { }
        public override void delete() { }
    }

    class QADB : DB
    {
        public override void select() { }
        public override void update() { }
        public override void delete() { }
    }
}
