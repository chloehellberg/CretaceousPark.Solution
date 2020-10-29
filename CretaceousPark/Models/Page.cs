// namespace CretaceousPark.Models
// {
//   public class Page
//   {
//     const int maxPageSize = 50;
//     public int PageNumber { get; set; } = 1;
//     private int _pageSize = 10;
//     public int PageSize //if it's being specified by the user then it calculates it??
//     {
//       get
//       {
//         return _pageSize;
//       }
//       set
//       {
//         _pageSize = (value > maxPageSize) ? maxPageSize : value;
//       }
//     }
//   }
// }