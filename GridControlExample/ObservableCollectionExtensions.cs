using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Reactive;
using System.Reactive.Linq;

namespace GridControlExample;
public static class ObservableCollectionExtensions
{
    public static IObservable<EventPattern<NotifyCollectionChangedEventArgs>>
    GetObservableChanges<T>(this ObservableCollection<T> collection)
    {
        return Observable.FromEventPattern<
            NotifyCollectionChangedEventHandler, NotifyCollectionChangedEventArgs>(
                h => collection.CollectionChanged += h,
                h => collection.CollectionChanged -= h
            );
    }

    public static IObservable<T> GetObservableAddedValues<T>(
        this ObservableCollection<T> collection)
    {
        return collection.GetObservableChanges()
            .Where(evnt => evnt.EventArgs.Action == NotifyCollectionChangedAction.Add)
            .SelectMany(evnt => evnt.EventArgs.NewItems?.Cast<T>() ?? new List<T>());
    }
}