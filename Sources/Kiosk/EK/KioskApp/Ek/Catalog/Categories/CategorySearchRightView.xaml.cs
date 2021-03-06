﻿using System;
using System.ComponentModel;
using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using KioskApp.Search;

namespace KioskApp.Ek.Catalog.Categories
{
    public sealed partial class CategorySearchRightView : UserControl
    {
        public CategorySearchRightView()
        {
            InitializeComponent();
        }

        #region SearchProvider

        public static readonly DependencyProperty SearchProviderProperty = DependencyProperty.Register(
            nameof(SearchProvider), typeof(ICategorySearchProvider), typeof(CategorySearchRightView), new PropertyMetadata(default(ICategorySearchProvider), SearchProviderPropertyChangedCallback));

        private static void SearchProviderPropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((CategorySearchRightView)d).OnSearchProviderChanged(e.OldValue as ICategorySearchProvider);
        }

        public ICategorySearchProvider SearchProvider
        {
            get => (ICategorySearchProvider)GetValue(SearchProviderProperty);
            set => SetValue(SearchProviderProperty, value);
        }

        #endregion

        private void OnSearchProviderChanged(ICategorySearchProvider previousProvider)
        {
            // synced by UI thread
            if (previousProvider != null)
            {
                previousProvider.PropertyChanged -= SearchProvider_PropertyChanged;
            }

            SearchProvider.PropertyChanged += SearchProvider_PropertyChanged;
            UpdateBreadcrumbs();
        }

        private void CategorySearchRightView_OnUnloaded(object sender, RoutedEventArgs e)
        {
            // synced by UI thread
            if (SearchProvider != null)
            {
                SearchProvider.PropertyChanged -= SearchProvider_PropertyChanged;
            }
        }

        private void SearchProvider_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case nameof(ICategorySearchProvider.Breadcrumbs):
                    UpdateBreadcrumbs();
                    break;
            }
        }

        #region Breadcrumbs

        public static readonly DependencyProperty BreadcrumbsProperty = DependencyProperty.Register(
            nameof(Breadcrumbs), typeof(BreadcrumbCategoryWrapper[]), typeof(CategorySearchRightView), new PropertyMetadata(default(BreadcrumbCategoryWrapper[])));

        public BreadcrumbCategoryWrapper[] Breadcrumbs
        {
            get => (BreadcrumbCategoryWrapper[])GetValue(BreadcrumbsProperty);
            set => SetValue(BreadcrumbsProperty, value);
        }

        #endregion

        private void UpdateBreadcrumbs()
        {
            Breadcrumbs = SearchProvider?.Breadcrumbs
                              ?.Select((x, i) => new BreadcrumbCategoryWrapper()
                                  {
                                      Index = i,
                                      Category = x,
                                  })
                              .ToArray()
                          ?? new BreadcrumbCategoryWrapper[0];
        }

        private void BreadcrumbPresenter_OnClick(object sender, EventArgs e)
        {
            var breadcrumbCategory = ((CategoryGroupPresenter)sender).Category;
            SearchProvider?.ChangeCategory(breadcrumbCategory);
        }

        private void Category_OnClick(object sender, EventArgs e)
        {
            var category = ((FrameworkElement)sender).Tag as Category;
            SearchProvider?.SelectCategory(category);
        }

        private void BackButton_OnClick(object sender, RoutedEventArgs e)
        {
            SearchProvider?.GoBack();
        }
    }
}