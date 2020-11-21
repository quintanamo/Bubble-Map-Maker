namespace Bubble_Map_Maker
{
    public class BubbleMapNode
    {
        private int id;
        private string caption;
        private int xPosition;
        private int yPosition;
        private int zPosition;
        private int size;
        private string backgroundColor;
        private string textColor;
        private int textSize;
        public string Caption
        {
            get { return caption; }
            set { caption = value; }
        }
        public int XPosition
        {
            get { return xPosition; }
            set { xPosition = value; }
        }
        public int YPosition
        {
            get { return yPosition; }
            set { yPosition = value; }
        }
        public int ZPosition
        {
            get { return zPosition; }
            set { zPosition = value; }
        }
        public int Size
        {
            get { return size; }
            set { size = value; }
        }
        public string BackgroundColor
        {
            get { return backgroundColor; }
            set { backgroundColor = value; }
        }
        public string TextColor
        {
            get { return textColor; }
            set { textColor = value; }
        }
        public int TextSize
        {
            get { return textSize; }
            set { textSize = value; }
        }
        public BubbleMapNode(int id, string caption, int xPos, int yPos, int zPos, int size, string backgroundColor, string textColor, int textSize)
        {
            this.id = id;
            this.caption = caption;
            this.xPosition = xPos;
            this.yPosition = yPos;
            this.zPosition = zPos;
            this.size = size;
            this.backgroundColor = backgroundColor;
            this.textColor = textColor;
            this.textSize = textSize;
        }

        public int getId()
        {
            return this.id;
        }
        public void setId(int id)
        {
            this.id = id;
        }

        public override string ToString()
        {
            return "Node ID: " + this.id + "\nNode Caption: " + this.caption + "\nNode Position: " + this.xPosition + ", " + this.yPosition + "\nNode Width: " + this.size + "\nNode BG Color: " + this.backgroundColor;
        }
    }
}