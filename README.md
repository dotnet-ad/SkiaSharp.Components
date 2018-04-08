# SkiaSharp.Components

[![NuGet](https://img.shields.io/nuget/v/SkiaSharp.Components.svg?label=NuGet)](https://www.nuget.org/packages/SkiaSharp.Components/) [![NuGet](https://img.shields.io/nuget/v/SkiaSharp.Components.Layout.svg?label=NuGet)](https://www.nuget.org/packages/SkiaSharp.Components.Layout/) [![Donate](https://img.shields.io/badge/donate-paypal-yellow.svg)](https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=ZJZKXPPGBKKAY&lc=US&item_name=GitHub&item_number=0000001&currency_code=USD&bn=PP%2dDonationsBF%3abtn_donate_SM%2egif%3aNonHosted)

Producing rendering code for [SkiaSharp](https://github.com/mono/SkiaSharp) can be extremely verbose and repetitive. **SkiaSharp.Components** are higher level views that make declarations more concise.

## Quickstart

```csharp
this.Title = new Label
{
    TextSize = 40,
    Text = "Title of the view",
    Frame = SKRect.Create(0,0,200,50),
};

this.Separator = new View
{
    BackgroundBrush = new ColorBrush(SKColors.Black),
    Frame = SKRect.Create(0,50,200,4),
};

this.Description = new Label
{
    TextSize = 15,
    BackgroundBrush = new ColorBrush(SKColors.White),
    CornerRadius = 50,
    ShadowSize = new SKSize(4,4),
    Text = "Nam ut imperdiet nibh. Ut sollicitudin varius nibh, id ornare tortor convallis sed. Morbi volutpat, lacus efficitur volutpat lacinia, nibh velit ultricies neque, vel faucibus tellus neque at nibh. Nullam vitae tincidunt metus. Vestibulum nec nisl quis lorem tincidunt maximus eu vel lectus. Proin posuere augue molestie imperdiet scelerisque. Phasellus quis suscipit neque.",
    Frame = SKRect.Create(0,54,200,200),
};

this.Image = new Image
{
    Source = "https://www.xamarin.com/content/images/pages/branding/assets/xamagon.png",
    Frame = SKRect.Create(0,254,200,100),
};

this.Icon = new Path
{
    Source = IconPath.ArrowUp,
    StrokeSize = 5,
    ViewBox = SKRect.Create(0, 0, 24, 24),
    Frame = SKRect.Create(0,354,50,50),
};

this.Title.Render(canvas);
this.Separator.Render(canvas);
this.Description.Render(canvas);
this.Image.Render(canvas);
this.Icon.Render(canvas);
```

## Advanced usage

### Subviews

Children views can be added to a view with `AddView` method. The `Frame` becomes relative to its parent.

### Invalidation

Each time a property of a view changes, the `Invalidated` event of a view is raised. This is useful to know when to re-render a view.

### Layout

A package containing layout helpers is available from `SkiaSharp.Components.Layout`. It combines the power of [SkiaSharp](https://github.com/mono/SkiaSharp) and [Yoga](https://github.com/facebook/Yoga) (and maybe [Xamarin.Flex](https://github.com/Xamarin/flex) soon).

See the [sample](/src/SkiaSharp.Components.Samples/SimpleFlexView.cs) for more details.

### Interactions

Basic interactions are available through the `Tap` control which raises events when the user touches its frame. It is a view like any other components.

```csharp
this.Button = new Tap()
{
    BackgroundBrush = new ColorBrush(SKColors.DeepPink),
    CornerRadius = 5,
};

this.Button.Tapped += (s,e) => Debug.WriteLine("Tapped");
this.Button.Pressed += (s, e) => ((Tap)s).BackgroundBrush = new ColorBrush(SKColors.LightPink);
this.Button.Released += (s, e) => ((Tap)s).BackgroundBrush = new ColorBrush(SKColors.DeepPink);
```

If you use provided `Layout` and its renderer, touches will be wired up automatically.

## Contributions

Contributions are welcome! If you find a bug please report it and if you want a feature please report it.

If you want to contribute code please file an issue and create a branch off of the current dev branch and file a pull request.

## License

MIT © [Aloïs Deniel](http://aloisdeniel.github.io)
