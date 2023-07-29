using Content.Client.Message;
using Content.Shared.Research.Prototypes;
using Robust.Client.AutoGenerated;
using Robust.Client.GameObjects;
using Robust.Client.UserInterface;
using Robust.Client.UserInterface.XAML;
using Robust.Shared.Prototypes;
using Robust.Shared.Utility;

namespace Content.Client.MassMedia.Ui;

[GenerateTypedNameReferences]
public sealed partial class MiniArticleCardControl : Control
{
    public Action? OnDeletePressed;
    public int ArtcileNum;

    public MiniArticleCardControl(string name)
    {
        RobustXamlLoader.Load(this);

        Name.SetMarkup(name);

        Delete.OnPressed += _ => OnDeletePressed?.Invoke();
    }
}
