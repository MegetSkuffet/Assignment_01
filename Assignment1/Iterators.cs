namespace Assignment1;

public static class Iterators
{
    // Flatten takes as argument a stream of a stream of T's. It should return a stream of T's.
    public static IEnumerable<T> Flatten<T>(IEnumerable<IEnumerable<T>> items){
        foreach(var item in items){
            foreach(var i in item){
                yield return i;
            }
        }
    } 

    // Filter takes as arguments a stream of T's and a function which returns true or false when applied to an instance of T. 
    // It returns a stream of only the Ts where the predicate returns true.
    public static IEnumerable<T> Filter<T>(IEnumerable<T> items, Predicate<T> predicate) {
        foreach(var item in items){
            if(predicate(item)){
                yield return item;
            }
        }
    }
}