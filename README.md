# show-attachment-button-in-left-and-editor-in-right-like-facebook-messenger-in-Xamarin.Forms.Chat
Shows how to display the attachment button and other buttons in left and display the editor in the right, in a Xamarin.Forms chat application using SfChat

## Sample

```xaml

        <ResourceDictionary>
            <!-- Customizing Message input view and used chat editor view  -->
            <Style TargetType="sfChat:MessageInputView">
                <Setter Property="ControlTemplate">
                    <Setter.Value>
                        <ControlTemplate>
                            <border:SfBorder x:Name="typingAreaView" BackgroundColor="#FFFFFF" CornerRadius="18" Padding="18,0,0,0" BindingContext="{TemplateBinding BindingContext}">
                                <Grid x:Name="typingAreaGrid" ColumnSpacing="0" BackgroundColor="#FFFFFF">
                                    <Grid.RowDefinitions>
                                        <RowDefinition Height="Auto"/>
                                    </Grid.RowDefinitions>

                                    <Grid.ColumnDefinitions>
                                        <ColumnDefinition Width="56"/>
                                        <ColumnDefinition Width="56"/>
                                        <ColumnDefinition Width="*"/>
                                    </Grid.ColumnDefinitions>

                                    <Image x:Name="attachmentView" HeightRequest="40" Source="AttachmentIcon.png" Grid.Row="0" Grid.Column="0"/>

                                    <Image x:Name="sendMessageView" HeightRequest="40" Source="SendIcon.png" Grid.Row="0" Grid.Column="1">
                                        <Image.GestureRecognizers>
                                            <TapGestureRecognizer Tapped="SendButton_Tapped"/>
                                        </Image.GestureRecognizers>
                                    </Image>

                                    <Grid Grid.Row="0" Grid.Column="2">
                                        <Grid.RowDefinitions>
                                            <RowDefinition Height="Auto"/>
                                        </Grid.RowDefinitions>
                                        <sfChat:ChatEditorView x:Name="chatEditor" >
                                        </sfChat:ChatEditorView>
                                    </Grid>
                                </Grid>
                            </border:SfBorder>
                        </ControlTemplate>
                    </Setter.Value>
                </Setter>
            </Style>
        </ResourceDictionary>

```

## Requirements to run the demo

* [Visual Studio 2017](https://visualstudio.microsoft.com/downloads/) or [Visual Studio for Mac](https://visualstudio.microsoft.com/vs/mac/)
* Xamarin add-ons for Visual Studio (available via the Visual Studio installer).

## Troubleshooting

### Path too long exception

If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.
