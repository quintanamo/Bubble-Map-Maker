using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bubble_Map_Maker
{
    public partial class mainForm : Form
    {
        private const bool DEBUG = true;
        private BubbleMapNode selectedNode;
        //private List<BubbleMapNode> nodeList = new List<BubbleMapNode>();
        private Dictionary<int, BubbleMapNode> nodeList = new Dictionary<int, BubbleMapNode>();
        private Dictionary<int, NodeConnection> nodeConnectionList = new Dictionary<int, NodeConnection>();

        private int mouseX;
        private int mouseY;
        private int originalX;
        private int originalY;
        private bool isMouseDown = false;
        public mainForm()
        {
            InitializeComponent();
        }

        private void addNodeButton_Click(object sender, EventArgs e)
        {
            if (DEBUG) Console.WriteLine("Adding a new node.");
            //nodeList.Add(new BubbleMapNode(nodeList.Count + 1, "New Node", 0, 0, nodeList.Count, 200, "#333333", "#ffffff", 12));
            BubbleMapNode newNode = new BubbleMapNode(nodeList.Count + 1, "New Node", 0, 0, nodeList.Count, 150, "#333333", "#ffffff", 12);
            nodeList.Add(nodeList.Count + 1, newNode);
            selectNode(newNode);
            if (DEBUG) Console.WriteLine("New node added, " + nodeList.Count + " in the node list.");
            showConnectionLineBox();
            canvas.Invalidate();
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            mouseX = e.X;
            mouseY = e.Y;
            if (isMouseDown && selectedNode != null)
            {
                selectedNode.XPosition += mouseX - originalX;
                selectedNode.YPosition += mouseY - originalY;
                originalX = mouseX;
                originalY = mouseY;
                nodeList[selectedNode.getId()] = selectedNode;
                canvas.Invalidate();
            }
        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            originalX = mouseX;
            originalY = mouseY;
            isMouseDown = true;
            selectedNode = null;
            for (int i = nodeList.Count; i > 0; i--)
            {
                if (hasClickedNode(nodeList[i].XPosition, nodeList[i].YPosition, nodeList[i].Size, mouseX, mouseY))
                {
                    if (DEBUG) Console.WriteLine("Node with id " + nodeList[i].getId() + " selected.");
                    selectedNode = nodeList[i];
                    selectNode(selectedNode);
                    break;
                }
            }
        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            if (selectedNode == null) selectedNodeBox.Visible = false;
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            // Initialize the graphics and set the smoothing mode to HQ
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            SolidBrush brush;
            Pen pen;

            // Draw node connections
            foreach (NodeConnection connection in nodeConnectionList.Values)
            {
                Color nodeConnectionColor = ColorTranslator.FromHtml(connection.Color);
                brush = new SolidBrush(nodeConnectionColor);
                pen = new Pen(brush, connection.Size);
                BubbleMapNode parentNode = nodeList[connection.getParentNodeId()];
                BubbleMapNode childNode = nodeList[connection.getChildNodeId()];
                Point parentNodePoint = new Point(parentNode.XPosition + parentNode.Size / 2, parentNode.YPosition + parentNode.Size / 2);
                Point childNodePoint = new Point(childNode.XPosition + childNode.Size / 2, childNode.YPosition + childNode.Size / 2);
                g.DrawLine(pen, parentNodePoint, childNodePoint);
            }

            // Draw nodes
            foreach (BubbleMapNode node in nodeList.Values)
            {
                // Draw the shape of the node itself
                //if (DEBUG) Console.WriteLine(node.ToString());
                Color nodeBackgroundColor = ColorTranslator.FromHtml(node.BackgroundColor);
                brush = new SolidBrush(nodeBackgroundColor);
                g.FillEllipse(brush, node.XPosition, node.YPosition, (node.Size), (node.Size));

                // Draw the caption inside of the node
                Color nodeTextColor = ColorTranslator.FromHtml(node.TextColor);
                brush = new SolidBrush(nodeTextColor);
                Font captionFont = new Font("Arial", node.TextSize, FontStyle.Regular, GraphicsUnit.Point);
                StringFormat sf = new StringFormat();
                sf.LineAlignment = StringAlignment.Center;
                sf.Alignment = StringAlignment.Center;
                g.DrawString(node.Caption, captionFont, brush, (node.XPosition + node.Size/2), (node.YPosition + node.Size/2), sf);
            }
        }

        public bool hasClickedNode(int circleX, int circleY, int size, int mouseX, int mouseY)
        {
            int r = size / 2;
            int dx = circleX + r - mouseX;
            int dy = circleY + r - mouseY;
            return (dx * dx) + (dy * dy) <= (r * r);
        }
        
        public void selectNode(BubbleMapNode node)
        {
            selectedNodeBox.Visible = true;
            captionTextbox.Text = node.Caption;
            sizeTextbox.Value = node.Size;
            bgColorTextbox.Text = node.BackgroundColor;
            textSizeTextbox.Value = node.TextSize;
            textColorTextbox.Text = node.TextColor;
        }

        public void updateNode()
        {
            if (selectedNode != null)
            {
                selectedNode.Caption = captionTextbox.Text;
                selectedNode.Size = (int)sizeTextbox.Value;
                selectedNode.BackgroundColor = bgColorTextbox.Text;
                selectedNode.TextSize = (int)textSizeTextbox.Value;
                selectedNode.TextColor = textColorTextbox.Text;
                nodeList[selectedNode.getId()] = selectedNode;
            }
        }

        public void updateConnectionLine()
        {
            foreach (NodeConnection connection in nodeConnectionList.Values)
            {
                connection.Size = (int)connectionLineWidthTextbox.Value;
                connection.Color = connectionLineColorTextbox.Text;
            }
        }

        private void updateNodeButton_Click(object sender, EventArgs e)
        {
            updateNode();
            canvas.Invalidate();
        }

        private void updateConnectionLineButton_Click(object sender, EventArgs e)
        {
            updateConnectionLine();
            canvas.Invalidate();
        }

        public void showConnectionLineBox()
        {
            if (nodeList.Count > 0)
            {
                connectionsBox.Visible = true;
            } else
            {
                connectionsBox.Visible = false;
            }
        }

        private void addChildNodeButton_Click(object sender, EventArgs e)
        {
            if (selectedNode != null)
            {
                BubbleMapNode newNode = new BubbleMapNode(nodeList.Count + 1, "New Node", 0, 0, nodeList.Count, 150, "#333333", "#ffffff", 12);
                nodeList.Add(nodeList.Count + 1, newNode);
                NodeConnection newConnection = new NodeConnection(nodeConnectionList.Count + 1, selectedNode.getId(), newNode.getId(), 2, "#333333");
                nodeConnectionList.Add(newConnection.getId(), newConnection);
                selectNode(newNode);
            }
            canvas.Invalidate();
        }

        private void deleteNodeButton_Click(object sender, EventArgs e)
        {
            if (selectedNode != null)
            {
                for (int i = selectedNode.getId(); i <= nodeList.Count; i++)
                {
                    if (nodeList.ContainsKey(i + 1))
                    {
                        nodeList[i] = nodeList[i + 1];
                        nodeList[i].setId(i);
                    }
                    else
                    {
                        nodeList.Remove(i);
                    }
                }
                List<int> connectionsToDelete = new List<int>();
                foreach (NodeConnection connection in nodeConnectionList.Values)
                {
                    if (connection.getParentNodeId() == selectedNode.getId() || connection.getChildNodeId() == selectedNode.getId())
                    {
                        connectionsToDelete.Add(connection.getId());
                        continue;
                    }
                    if (connection.getParentNodeId() > selectedNode.getId()) connection.setParentNodeId(connection.getParentNodeId() - 1);
                    if (connection.getChildNodeId() > selectedNode.getId()) connection.setChildNodeId(connection.getChildNodeId() - 1);
                }
                foreach (int id in connectionsToDelete)
                {
                    nodeConnectionList.Remove(id);
                }
                selectedNode = null;
                selectedNodeBox.Visible = false;
            }
            showConnectionLineBox();
            canvas.Invalidate();
        }

    }
}
