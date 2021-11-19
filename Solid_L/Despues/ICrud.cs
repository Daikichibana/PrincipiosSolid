namespace Solid_L.Despues
{
    interface ICrud : IAdd, IUpdate, IDelete, IGet
    {  
    }

    interface IAdd
    {
        public void Add();
    }

    interface IUpdate
    {
        public void Update();
    }

    interface IDelete
    {
        public void Delete();
    }

    interface IGet
    {
        public void Get();
    }
}
