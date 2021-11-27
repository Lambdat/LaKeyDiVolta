namespace LaKeyDiVolta.Models
{
    /*
     * Un interfaccia è vista come un contratto contenente le firme dei metodi che dovranno essere
     * poi implementati dalle classi interessate;
     * 
     * UN INTERFACCIA NON PUO' avere ne campi ne proprietà e NON È POSSIBILIE ISTANZIRE OGGETTI DA ESSA
     * 
     * 
     */

    public interface IDAO<T>
    {
        public List<T> GetAllElements();
        public List<T> GetElementsBy();
        public void Insert (T t);
        public void Update(T t);
        public void Delete (T t);

    }
}
