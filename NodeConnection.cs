namespace Bubble_Map_Maker
{
    public class NodeConnection
    {
        private int id;
        private int parentNodeId;
        private int childNodeId;
        private int size;
        private string color;

        public int Size
        {
            get { return size; }
            set { size = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public NodeConnection(int id, int parentNodeId, int childNodeId, int size, string color)
        {
            this.id = id;
            this.parentNodeId = parentNodeId;
            this.childNodeId = childNodeId;
            this.size = size;
            this.color = color;
        }

        public int getId()
        {
            return id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public int getParentNodeId()
        {
            return parentNodeId;
        }

        public void setParentNodeId(int id)
        {
            this.parentNodeId = id;
        }

        public int getChildNodeId()
        {
            return childNodeId;
        }
        public void setChildNodeId(int id)
        {
            this.childNodeId = id;
        }

    }
}
