using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface.CustomControls;
using Robust.Client.UserInterface.XAML;

namespace Content.Client._CorvaxNext.Surgery;

[GenerateTypedNameReferences]
public sealed partial class SurgeryWindow : DefaultWindow
{
    public SurgeryWindow()
    {
        RobustXamlLoader.Load(this);
    }
}
