export interface IPagedList<T> {
    TotalItemCount: number = 0;
    Count: number = 0;
    PageCount: number
    CurrentPage: number
    Data: T[];


}
