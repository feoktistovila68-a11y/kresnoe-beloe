<Window x:Class="KrasnoeBeloe.BeloeMain"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        Title="Красное &amp; Белое - Система управления" 
        Height="600" Width="900"
        WindowStartupLocation="CenterScreen"
        Background="#F5F5F5"
        ResizeMode="CanResize">
    
    <Grid Margin="20">
        <Grid.RowDefinitions>
            <RowDefinition Height="Auto"/>
            <RowDefinition Height="*"/>
            <RowDefinition Height="Auto"/>
        </Grid.RowDefinitions>
        
        <!-- Заголовок -->
        <Border Grid.Row="0" Background="#CC0000" CornerRadius="10" Height="80" Margin="0,0,0,10">
            <StackPanel Orientation="Horizontal" HorizontalAlignment="Center" VerticalAlignment="Center">
                <TextBlock Text="🍷 КРАСНОЕ &amp; БЕЛОЕ" FontSize="28" FontWeight="Bold" Foreground="White" Margin="10,0"/>
                <TextBlock Text="| Система управления" FontSize="18" Foreground="#FFE0E0" Margin="20,0,0,0"/>
            </StackPanel>
        </Border>
        
        <!-- Основной контент -->
        <TabControl Grid.Row="1" Margin="0,10,0,10" FontSize="14">
            <!-- Вкладка 1: Товары -->
            <TabItem Header="📦 Товары" Margin="5">
                <Grid Margin="10">
                    <Grid.RowDefinitions>
                        <RowDefinition Height="Auto"/>
                        <RowDefinition Height="Auto"/>
                        <RowDefinition Height="*"/>
                    </Grid.RowDefinitions>
                    
                    <StackPanel Grid.Row="0" Orientation="Horizontal" Margin="0,0,0,10">
                        <Label Content="Поиск:" Style="{StaticResource LabelStyle}" Margin="0,0,10,0"/>
                        <TextBox x:Name="txtSearch" Width="200" Height="30" ToolTip="Введите название товара"/>
                        <Button x:Name="btnSearch" Content="🔍 Найти" Style="{StaticResource ButtonStyle}" Margin="10,0,0,0" Click="btnSearch_Click"/>
                        <Button x:Name="btnAddProduct" Content="➕ Добавить" Style="{StaticResource ButtonStyle}" Margin="10,0,0,0" Click="btnAddProduct_Click"/>
                    </StackPanel>
                    
                    <DataGrid x:Name="dgProducts" Grid.Row="2" 
                              AutoGenerateColumns="True" 
                              Background="White"
                              BorderBrush="#CC0000"
                              BorderThickness="2"
                              CanUserAddRows="False"
                              CanUserDeleteRows="True">
                        <DataGrid.ColumnHeaderStyle>
                            <Style TargetType="DataGridColumnHeader">
                                <Setter Property="Background" Value="#CC0000"/>
                                <Setter Property="Foreground" Value="White"/>
                                <Setter Property="FontWeight" Value="Bold"/>
                            </Style>
                        </DataGrid.ColumnHeaderStyle>
                    </DataGrid>
                </Grid>
            </TabItem>
            
            <!-- Вкладка 2: Клиенты -->
            <TabItem Header="👤 Клиенты" Margin="5">
                <Grid Margin="10">
                    <Grid.RowDefinitions>
                        <RowDefinition Height="Auto"/>
                        <RowDefinition Height="*"/>
                    </Grid.RowDefinitions>
                    
                    <StackPanel Grid.Row="0" Orientation="Horizontal" Margin="0,0,0,10">
                        <Label Content="Клубная карта:" Style="{StaticResource LabelStyle}" Margin="0,0,10,0"/>
                        <TextBox x:Name="txtCardNumber" Width="150" Height="30" ToolTip="Введите номер карты"/>
                        <Button x:Name="btnFindClient" Content="🔍 Найти" Style="{StaticResource ButtonStyle}" Margin="10,0,0,0" Click="btnFindClient_Click"/>
                        <Button x:Name="btnAddClient" Content="➕ Добавить" Style="{StaticResource ButtonStyle}" Margin="10,0,0,0" Click="btnAddClient_Click"/>
                    </StackPanel>
                    
                    <DataGrid x:Name="dgClients" Grid.Row="1" 
                              AutoGenerateColumns="True" 
                              Background="White"
                              BorderBrush="#CC0000"
                              BorderThickness="2">
                        <DataGrid.ColumnHeaderStyle>
                            <Style TargetType="DataGridColumnHeader">
                                <Setter Property="Background" Value="#CC0000"/>
                                <Setter Property="Foreground" Value="White"/>
                                <Setter Property="FontWeight" Value="Bold"/>
                            </Style>
                        </DataGrid.ColumnHeaderStyle>
                    </DataGrid>
                </Grid>
            </TabItem>
            
            <!-- Вкладка 3: Продажи -->
            <TabItem Header="🧾 Продажи" Margin="5">
                <Grid Margin="10">
                    <Grid.RowDefinitions>
                        <RowDefinition Height="Auto"/>
                        <RowDefinition Height="*"/>
                    </Grid.RowDefinitions>
                    
                    <StackPanel Grid.Row="0" Orientation="Horizontal" Margin="0,0,0,10">
                        <Label Content="Дата:" Style="{StaticResource LabelStyle}" Margin="0,0,10,0"/>
                        <DatePicker x:Name="dpSaleDate" Width="150" Height="30" SelectedDate="{x:Static sys:DateTime.Now}"/>
                        <Button x:Name="btnShowSales" Content="📊 Показать" Style="{StaticResource ButtonStyle}" Margin="10,0,0,0" Click="btnShowSales_Click"/>
                        <Button x:Name="btnNewSale" Content="🛒 Новая продажа" Style="{StaticResource ButtonStyle}" Margin="10,0,0,0" Click="btnNewSale_Click"/>
                    </StackPanel>
                    
                    <DataGrid x:Name="dgSales" Grid.Row="1" 
                              AutoGenerateColumns="True" 
                              Background="White"
                              BorderBrush="#CC0000"
                              BorderThickness="2">
                        <DataGrid.ColumnHeaderStyle>
                            <Style TargetType="DataGridColumnHeader">
                                <Setter Property="Background" Value="#CC0000"/>
                                <Setter Property="Foreground" Value="White"/>
                                <Setter Property="FontWeight" Value="Bold"/>
                            </Style>
                        </DataGrid.ColumnHeaderStyle>
                    </DataGrid>
                </Grid>
            </TabItem>
        </TabControl>
        
        <!-- Статус бар -->
        <StatusBar Grid.Row="2" Background="#CC0000" Foreground="White" Height="30" Margin="0,10,0,0">
            <StatusBarItem>
                <TextBlock x:Name="tbStatus" Text="✅ Система готова к работе | Красное &amp; Белое v1.0" />
            </StatusBarItem>
            <Separator/>
            <StatusBarItem>
                <TextBlock x:Name="tbTime" Text="{x:Static sys:DateTime.Now}" />
            </StatusBarItem>
        </StatusBar>
    </Grid>
</Window>