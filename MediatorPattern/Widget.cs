namespace MediatorPattern
{
    public class Widget
    {
        private readonly Mediator _dialogMediator;

        public Widget(Mediator dialogMediator)
        {
            _dialogMediator = dialogMediator;
        }

        public void Changed()
        {
            _dialogMediator.WidgetChanged(this);
        }
    }
}