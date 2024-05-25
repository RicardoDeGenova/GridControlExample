using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Reactive;
using GridControlExample.Extensions;

namespace GridControlExample;

public partial class MainScreen : Form
{
    private readonly Database _database = new();
    private readonly ObservableCollection<Seed> SeedsList = new();
    private IDisposable _collectionObserverDisposable;

    public MainScreen()
    {
        InitializeComponent();

        // ------- Com Binding (o que recomendo) -------

        dataGridViewComBinding.DoubleBuffered(true);

        dataGridViewComBinding.DataSource = SeedsList.ToList();
        _collectionObserverDisposable = SeedsList.GetObservableChanges().Subscribe(SeedListChanged);

        // ------- Sem Binding (não recomendo) -------

        dataGridViewSemBinding.DoubleBuffered(true);

        dataGridViewSemBinding.Columns.Add(nameof(Seed.Id), "Id");
        dataGridViewSemBinding.Columns.Add(nameof(Seed.Name), "Nome");
        dataGridViewSemBinding.Columns.Add(nameof(Seed.Description), "Descrição");
        dataGridViewSemBinding.Columns.Add(nameof(Seed.Category), "Categoria");
        dataGridViewSemBinding.Columns.Add(nameof(Seed.Quantity), "Qtde");
        dataGridViewSemBinding.Columns.Add(nameof(Seed.UnitPrice), "Preço Unitário");
        dataGridViewSemBinding.Columns.Add(nameof(Seed.TotalPrice), "R$ Total");

        dataGridViewSemBinding.CellValueChanged += DataGridViewSemBinding_CellValueChanged;
    }

    private void SeedListChanged(EventPattern<NotifyCollectionChangedEventArgs> pattern)
    {
        menuStrip.Enabled = SeedsList.Any();
    }

    ~MainScreen()
    {
        _collectionObserverDisposable.Dispose();
    }

    private void ButtonPopulateGrids_Click(object sender, EventArgs e)
    {
        var seed = _database.GetSeed(x => x.Id == 3);
        if (seed == null) return;
        SeedsList.Clear();
        SeedsList.Add(seed);

        dataGridViewComBinding.DataSource = SeedsList.ToList();

        // --------------

        SeedsList.Clear();
        dataGridViewSemBinding.Rows.Add(
            seed.Id,
            seed.Name,
            seed.Description,
            seed.Category,
            seed.Quantity,
            seed.UnitPrice,
            seed.TotalPrice);
    }

    private void DataGridViewSemBinding_CellValueChanged(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.ColumnIndex < 0) return;
        if (e.RowIndex < 0) return;
        if (!dataGridViewSemBinding.Columns.Contains(nameof(Seed.Id))) return;

        var idColumnIndex = dataGridViewSemBinding.Columns[nameof(Seed.Id)].Index;
        if (e.ColumnIndex != idColumnIndex) return;

        var idCellValue = dataGridViewSemBinding.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
        if (idCellValue == null)
        {
            dataGridViewSemBinding.Rows.RemoveAt(e.RowIndex);
            return;
        }

        bool success = long.TryParse(idCellValue.ToString(), out long longCellValue);

        if (!success || longCellValue < 0)
        {
            MessageBox.Show("Valor inserido é inválido!");
            dataGridViewSemBinding.Rows.RemoveAt(e.RowIndex);
            return;
        }

        var seed = _database.GetSeed(s => s.Id == longCellValue);

        if (seed is null)
        {
            MessageBox.Show($"Produto com id {longCellValue} não encontrado!");
            dataGridViewSemBinding.Rows.RemoveAt(e.RowIndex);
            return;
        }

        dataGridViewSemBinding.Rows[e.RowIndex].Cells[nameof(Seed.Id)].Value = seed.Id;
        dataGridViewSemBinding.Rows[e.RowIndex].Cells[nameof(Seed.Name)].Value = seed.Name;
        dataGridViewSemBinding.Rows[e.RowIndex].Cells[nameof(Seed.Description)].Value = seed.Description;
        dataGridViewSemBinding.Rows[e.RowIndex].Cells[nameof(Seed.Category)].Value = seed.Category;
        dataGridViewSemBinding.Rows[e.RowIndex].Cells[nameof(Seed.Quantity)].Value = seed.Quantity;
        dataGridViewSemBinding.Rows[e.RowIndex].Cells[nameof(Seed.UnitPrice)].Value = seed.UnitPrice;
        dataGridViewSemBinding.Rows[e.RowIndex].Cells[nameof(Seed.TotalPrice)].Value = seed.TotalPrice;
    }
}
