# ZedGraph

https://sourceforge.net/projects/zedgraph/ ::zedgraph dll file
https://www.quora.com/How-do-you-add-Zedgraph-to-Visual-Studio
To add ZedGraph to a Visual Studio project, you can follow these steps:

Using NuGet Package Manager

Open Visual Studio: Launch your Visual Studio and open the project where you want to add ZedGraph.
Open NuGet Package Manager:
- Right-click on your project in the Solution Explorer.
- Select Manage NuGet Packages.
Browse for ZedGraph:
- Go to the Browse tab.
- Search for "ZedGraph".
Install the Package:
- Click on the ZedGraph package in the list.
- Click the Install button.
- Follow any prompts to complete the installation.
Verify Installation:
- After installation, you should see ZedGraph listed under the Installed tab in the NuGet Package Manager.
Manual Installation

If you prefer to manually add ZedGraph:

Download ZedGraph:
- Go to the ZedGraph website or GitHub repository.
- Download the latest release of ZedGraph.
Add Reference:
- Right-click on your project in the Solution Explorer.
- Select Add > Reference.
- In the Reference Manager, click on Browse and navigate to where you downloaded ZedGraph.
- Select the appropriate ZedGraph DLL file and click Add.
Include Namespace:
- In your code files where you want to use ZedGraph, include the namespace:
csharp 
     using ZedGraph; 
Example Usage

After adding ZedGraph, you can create a simple graph like this:

using ZedGraph; 
 
public void CreateGraph() 
{ 
    GraphPane myPane = new GraphPane(); 
    myPane.Title.Text = "My Graph"; 
    myPane.XAxis.Title.Text = "X Axis"; 
    myPane.YAxis.Title.Text = "Y Axis"; 
 
    PointPairList list = new PointPairList(); 
    list.Add(1, 2); 
    list.Add(2, 3); 
    list.Add(3, 5); 
    myPane.AddCurve("Curve", list, System.Drawing.Color.Red); 
 
    zedGraphControl1.GraphPane = myPane; 
    zedGraphControl1.Refresh(); 
} 
Conclusion

By following these steps, you should be able to successfully integrate ZedGraph into your Visual Studio project. If you encounter any issues, make sure to check the output window for any error messages and ensure that your project is set up correctly to reference the ZedGraph library.
