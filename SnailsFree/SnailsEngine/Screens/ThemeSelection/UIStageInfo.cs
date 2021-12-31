﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TwoBrainsGames.BrainEngine.UI.Controls;
using TwoBrainsGames.Snails.Stages;
using TwoBrainsGames.BrainEngine.UI.Screens;
using TwoBrainsGames.Snails.Screens.CommonControls;
using Microsoft.Xna.Framework;
using TwoBrainsGames.Snails.Player;
using TwoBrainsGames.BrainEngine.Localization;
using TwoBrainsGames.Snails.Effects;
using TwoBrainsGames.BrainEngine.Effects.TransformEffects;
using TwoBrainsGames.BrainEngine.UI;
using TwoBrainsGames.BrainEngine.Input;
using TwoBrainsGames.BrainEngine;
using TwoBrainsGames.BrainEngine.Resources;
using TwoBrainsGames.BrainEngine.Graphics;

namespace TwoBrainsGames.Snails.Screens.ThemeSelection
{
	class UIStageInfo : UIControl
	{

		public event UIEvent OnInfoFilled;
		public event UIEvent OnInfoCleared;
		public event UIEvent OnStartLoadingThumbnails;
		public event UIEvent OnEndLoadingThumbnails;

		public LevelStage StageInfo { get; private set; }
		private UICaption _capModeName;
		private UIValuedCaption _capGoal;
		private UIValuedCaption _capSnailsReleased;
		private UIImage _imgBackground;
		private UISnailsStageGoalIcon _goalIcon;
		private UISnailsMedal _medal;
		private UIPanel _container;
		private UICaption _capTap;

		private UICaption _capGoldMedal;
		private UICaption _capGoldMedalTime;
		private UICaption _capGoldMedalScore;
		private UICaption _capYourBest;
		private UICaption _capYourBestTime;
		private UICaption _capYourBestScore;
		private UIImage _imgLevelThumbnail;

		private bool _thumbnailsLoadingStarted;

		private float LineSpacing { get; set; }
		private bool WithShowHideEffects { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public UIStageInfo(UIScreen screenOwner) :
		base(screenOwner)
		{
			// Container
			this._container = new UIPanel(screenOwner);
			this._container.OnHide += new UIEvent(_container_OnHide);
			this.Controls.Add(this._container);

			// Background
			this._imgBackground = new UIImage(screenOwner, "spriteset/menu-elements-1/Notebook", ResourceManager.RES_MANAGER_ID_TEMPORARY);

			this.Size = this._imgBackground.Size;
			this._container.Size = this.Size;
			this._container.Controls.Add(this._imgBackground);

			// Goal icon
			this._goalIcon = new UISnailsStageGoalIcon(screenOwner);
			this._goalIcon.Position = new Vector2(-100, -100);
			this._container.Controls.Add(this._goalIcon);

			// Mode name
			this._capModeName = new UICaption(screenOwner, "", Colors.StageSelectionNotebookStageMode, UICaption.CaptionStyle.StageInfoHeader);
			this._container.Controls.Add(this._capModeName);

			// Goal
			this._capGoal = new UIValuedCaption(screenOwner, "LBL_STAGE_INFO_GOAL", "", Color.Black, Colors.StageSelectionNotebookText, UICaption.CaptionStyle.StageInfoDetail, this.Size.Width - this.PixelsToScreenUnitsX(45.0f), false, false);
			this._capGoal.AnimateValue = false;
			this._container.Controls.Add(this._capGoal);

			// Snails released
			this._capSnailsReleased = new UIValuedCaption(screenOwner, "LBL_STAGE_INFO_SNAIL_COUNT", 0, Color.Black, Colors.StageSelectionNotebookText, UICaption.CaptionStyle.StageInfoDetail, this._capGoal.Size.Width, false, false);
			this._capSnailsReleased.AnimateValue = false;
			this._container.Controls.Add(this._capSnailsReleased);

			// Medal
			this._medal = new UISnailsMedal(screenOwner, Snails.MedalType.None);
			this._medal.Position = new Vector2(this.Size.Width - 150.0f, 300.0f);
			this._medal.MedalSize = UISnailsMedal.MedalSizeType.Small;
			this._medal.IgnoreShowEffect = true;
			this._container.Controls.Add(this._medal);

			this._capTap = new UICaption(screenOwner, "", Color.OrangeRed, UICaption.CaptionStyle.StageInfoDetail);
			this._capTap.TextResourceId = "LBL_STAGE_INFO_TAP";
			this._capTap.HorizontalAligment = BrainEngine.UI.HorizontalTextAligment.Center;
			this._capTap.ParentAlignment = BrainEngine.UI.AlignModes.HorizontalyVertically;           

			if (SnailsGame.Settings.UseTouch)
			{
				this._container.Controls.Add(this._capTap);
			}

			// Gold Medal:
			this._capGoldMedal = new UICaption(screenOwner, "", Color.Black, UICaption.CaptionStyle.StageInfoDetail);
			this._capGoldMedal.TextResourceId = "LBL_STAGE_INFO_GOLD_MEDAL";
			this._container.Controls.Add(this._capGoldMedal);
			// Gold Medal points:
			this._capGoldMedalScore = new UICaption(screenOwner, "", Colors.StageSelectionNotebookHighScoreText, UICaption.CaptionStyle.StageInfoDetail);
			this._container.Controls.Add(this._capGoldMedalScore);
			// Gold Medal time:
			this._capGoldMedalTime = new UICaption(screenOwner, "", Colors.StageSelectionNotebookHighScoreText, UICaption.CaptionStyle.StageInfoDetail);
			this._container.Controls.Add(this._capGoldMedalTime);
			// Your best:
			this._capYourBest = new UICaption(screenOwner, "", Color.Black, UICaption.CaptionStyle.StageInfoDetail);
			this._capYourBest.TextResourceId = "LBL_STAGE_INFO_YOUR_BEST";
			this._container.Controls.Add(this._capYourBest);
			// Your best points:
			this._capYourBestScore = new UICaption(screenOwner, "", Colors.StageSelectionNotebookHighScoreText, UICaption.CaptionStyle.StageInfoDetail);
			this._container.Controls.Add(this._capYourBestScore);
			// Your best time:
			this._capYourBestTime = new UICaption(screenOwner, "", Colors.StageSelectionNotebookHighScoreText, UICaption.CaptionStyle.StageInfoDetail);
			this._container.Controls.Add(this._capYourBestTime);

			this._imgLevelThumbnail = new UIImage(screenOwner);
			this._imgLevelThumbnail.Position = this.PixelsToScreenUnits(new Vector2(180f, 110f));
			this._imgLevelThumbnail.Animate = false;
			this._container.Controls.Add(this._imgLevelThumbnail); 


			this.OnLanguageChanged += new UIEvent(UIStageInfo_OnLanguageChanged);
		}


		/// <summary>
		/// 
		/// </summary>
		void _container_OnHide(IUIControl sender)
		{
			this.Visible = false;
		}


		private void SetLabelsPositions()
		{
			this.LineSpacing = this.PixelsToScreenUnitsY (25);
			this._capModeName.Position = this.PixelsToScreenUnits(new Vector2(60,15));

			this._capGoal.Position = this.PixelsToScreenUnits(new Vector2(20f, 50f));
			this._capSnailsReleased.Position = this._capGoal.Position + new Vector2(0.0f, this.LineSpacing);
			this._capSnailsReleased.Position = this._capGoal.Position + new Vector2(0f, this.LineSpacing);
			this._capGoldMedal.Position = this._capSnailsReleased.Position + new Vector2(0f, this.LineSpacing);
			this._capGoldMedalScore.Position = this._capGoldMedal.Position + new Vector2(this.PixelsToScreenUnitsX(15), this.LineSpacing);
			this._capGoldMedalTime.Position = this._capGoldMedalScore.Position + new Vector2(0f, this.LineSpacing);
			this._capYourBest.Position = this._capGoldMedalTime.Position + new Vector2(this.PixelsToScreenUnitsX(-15), this.LineSpacing);
			this._capYourBestScore.Position = this._capYourBest.Position + new Vector2(this.PixelsToScreenUnitsX(15), this.LineSpacing);
			this._capYourBestTime.Position = this._capYourBestScore.Position + new Vector2(0f, this.LineSpacing);

		}


		/// <summary>
		/// 
		/// </summary>
		public void Initialize(LevelStage levelStage)
		{
			this.WithShowHideEffects = false;

			if (this.WithShowHideEffects)
			{
				this._container.ParentAlignment = BrainEngine.UI.AlignModes.HorizontalyVertically;
				this._container.ShowEffect = new SquashEffect(0.85f, 4.0f, 0.03f, this.BlendColor, this.Scale);
				this._container.HideEffect = new PopOutEffect(new Vector2(1.2f, 1.2f), 6.0f);
			}

			this.SetLabelsPositions();
			ShowHideTapMessage(false);

			this.StageInfo = levelStage;
			this.UpdateCaptionValues();


			if (this.OnInfoFilled != null)
			{
				this.OnInfoFilled(this);
			}
		}

		/// <summary>
		/// 
		/// </summary>
		void UIStageInfo_OnLanguageChanged(IUIControl sender)
		{
			this.UpdateCaptionValues();
		}

		/// <summary>
		/// Called when the control initializes or when the language changes
		/// </summary>
		private void UpdateCaptionValues()
		{

			if (this.StageInfo != null)
			{
				//this._capStageNr.Value = this.StageInfo.StageNr;
				this._goalIcon.Goal = this.StageInfo._goal;
				this._capModeName.Text = /*LanguageManager.GetString("LBL_MODE")*/ this.StageInfo.StageNr.ToString() + " - " + Formater.FormatModeName(this.StageInfo._goal);
				this._capGoal.Value = Formater.FormatGoalDescription(this.StageInfo);
				this._capSnailsReleased.Value = this.StageInfo._snailsToRelease;
				this._capGoldMedalScore.Text = Formater.FormatLevelScore(this.StageInfo._goldMedalScore);
				this._capGoldMedalTime.Text = Formater.FormatLevelTime(this.StageInfo._goldMedalTime);

				// Best score
				this._capYourBestScore.Text = "-";
				this._capYourBestTime.Text = "-";
				this._medal.Visible = false;
				if (SnailsGame.ProfilesManager.CurrentProfile != null)
				{
					PlayerStageStats stageStats = SnailsGame.ProfilesManager.CurrentProfile.PlayerStats.GetStageStats(this.StageInfo.StageId);
					if (stageStats != null && stageStats.WasPlayed)
					{
						this._capYourBestScore.Text = Formater.FormatLevelScore(stageStats.Highscore);
						this._capYourBestTime.Text = Formater.FormatLevelTime(stageStats.CompletionTime);
						if (stageStats.Medal != MedalType.None)
						{
							this._medal.Visible = true;
							this._medal.Face = stageStats.Medal;
						}
					}
				}

				if (this.OnStartLoadingThumbnails != null) {
					this.OnStartLoadingThumbnails (this);

				}
				//	this.LoadThumbnails ();
				// Thumbnail
				//  this._imgLevelThumbnail.Sprite = BrainGame.ResourceManager.GetSprite("spriteset/" + this.StageInfo.ThemeId.ToString() + "/thumbnails/"+ this.StageInfo.StageKey, ResourceManagerIds.STAGE_THUMBNAILS);
				//this._imgLevelThumbnail.Visible = (this._imgLevelThumbnail.FrameCount > 0);
			}
		}

	
		/// <summary>
		/// 
		/// </summary>
		public void ShowHideTapMessage(bool enable)
		{
			if (SnailsGame.Settings.UseTouch)
			{
				this._capTap.Visible = enable;
				this._goalIcon.Visible = !enable;
				this._capModeName.Visible = !enable;
				this._capGoal.Visible = !enable;
				this._capSnailsReleased.Visible = !enable;
				this._medal.Visible = !enable;
				this._capGoldMedal.Visible = !enable;
				this._capGoldMedalScore.Visible = !enable;
				this._capGoldMedalTime.Visible = !enable;
				this._capYourBest.Visible = !enable;
				this._capYourBestScore.Visible = !enable;
				this._capYourBestTime.Visible = !enable;
				this._imgLevelThumbnail.Visible = !enable;

				if (this.OnInfoCleared != null)
				{
					this.OnInfoCleared(this);
				}
			}
		}

		public void Show(LevelStage levelStage)
		{
			this.Visible = true;
			this._container.Visible = true;
			this.ShowHideTapMessage(true);
			this.Initialize (levelStage);
			this._imgLevelThumbnail.Sprite = BrainGame.ResourceManager.GetSprite ("spriteset/" + this.StageInfo.ThemeId.ToString () + "/thumbnails/" + this.StageInfo.StageKey, ResourceManagerIds.STAGE_THUMBNAILS);
		}

	}
}
