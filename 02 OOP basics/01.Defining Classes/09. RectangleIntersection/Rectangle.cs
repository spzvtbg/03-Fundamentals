public class Rectangle
{
    public Rectangle(string id = default(string), double width = 0, double height = 0, double left = 0, double top = 0)
    {
        this.Id = id;
        this.Width = width;
        this.Height = height;
        this.Left = left;                                         
        this.Top = top;                                           
    }                                                             
                                                                  
    public string Id { get; set; }                                
                                                                  
    public double Width { get; set; }                             
                                                                  
    public double Height { get; set; }                            
                                                                  
    public double Left { get; set; }                              

    public double Top { get; set; }                                                         

    public bool Intersects(Rectangle another)
    {
        bool leftTop = this.Top <= another.Top &&
                       this.Top >= another.Top - another.Height &&
                       this.Left >= another.Left &&
                       this.Left <= another.Left + another.Width;

        bool rightTop = this.Top <= another.Top &&
                        this.Top >= another.Top - another.Height &&
                        this.Left + this.Width >= another.Left &&
                        this.Left + this.Width <= another.Left + another.Width;

        bool leftBottom = this.Top - this.Height <= another.Top &&
                          this.Top - this.Height >= another.Top - another.Height &&
                          this.Left >= another.Left &&
                          this.Left <= another.Left + another.Width;

        bool rightBottom = this.Top - this.Height <= another.Top &&
                           this.Top - this.Height >= another.Top - another.Height &&
                           this.Left + this.Width >= another.Left &&
                           this.Left + this.Width <= another.Left + another.Width;

        if (leftTop || rightTop || leftBottom || rightBottom)
        {
            return true;
        }
        return false;
    }
}
