using System.ComponentModel.DataAnnotations;

namespace Efficiency.Models;

public class FinancialResult
{
    [Key]
    [Required(ErrorMessage = "The financial result's id is not optional")]
    public int ID { get; set; }

    [Required(ErrorMessage = "The financial result's date is not optional")]
    public DateTime Date { get; set; }

    [Required(ErrorMessage = "The financial result's product sales result is not optional")]
    public decimal ProductSalesResult { get; set; }
    public virtual ICollection<Employee>? Employees { get; set; }
    public virtual ICollection<FinancialService>? FinancialServices { get; set; }
    public virtual ICollection<FinancialResultFinancialService>? FinancialResultsFinancialServices { get; set; }
}