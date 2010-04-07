//
//  plusSignAppDelegate.m
//  plusSign
//
//  Created by Genki-Oki on 9/7/09.
//  Copyright Genki-Oki 2009. All rights reserved.
//

#import "plusSignAppDelegate.h"

@implementation plusSignAppDelegate
- (void) loadIntro{
	/*******/
	NSBundle *bundle = [NSBundle mainBundle];
	NSString *moviePath = [bundle pathForResource:@"GO" ofType:@"m4v"];// initWithPath:CONSTANT_GOINTRO_INTRO];
	
	NSURL *movieURL;
	
	if (moviePath)
	{
		movieURL = [NSURL fileURLWithPath:moviePath];
	}
	
	if (movieURL != nil) {
		moviePlayer = [[MPMoviePlayerController alloc] initWithContentURL:movieURL];
		
		// Register to receive a notification when the movie has finished playing. 
		[[NSNotificationCenter defaultCenter] addObserver:self
												 selector:@selector(moviePlayBackDidFinish:) 
													 name:MPMoviePlayerPlaybackDidFinishNotification 
												   object:moviePlayer];
		
		moviePlayer.scalingMode = MPMovieScalingModeAspectFill; 
		moviePlayer.movieControlMode = MPMovieControlModeHidden;
		moviePlayer.backgroundColor = [UIColor greenColor];
		
	
		[moviePlayer play];
		}}
-(void)moviePlayBackDidFinish: (NSNotification*)notification
{	
	[[NSNotificationCenter defaultCenter] removeObserver:self name:@"MPMoviePlayerPlaybackDidFinishNotification" object:nil];
	MPMoviePlayerController* moviePlayer2 = [notification object];
	[moviePlayer2 stop];
	[moviePlayer2 release];
	[self performSelector:@selector(resumeAfterMovie) withObject:nil afterDelay:2.0];
}

- (void) resumeAfterMovie {
	[[CDAudioManager sharedManager] audioSessionResumed];
	[[Director sharedDirector] replaceScene:[IntroScene node]];
}

- (void)applicationDidFinishLaunching:(UIApplication *)application {    
	UIWindow *window = [[UIWindow alloc] initWithFrame:[[UIScreen mainScreen] bounds]];
	[window setUserInteractionEnabled:YES];
	[window setMultipleTouchEnabled:YES];
	[[Director sharedDirector] setDeviceOrientation: CCDeviceOrientationPortrait];
	[[Director sharedDirector] attachInWindow:window];
	
	[window makeKeyAndVisible];
	
	BlankScene *ms = [BlankScene node];
	[[Director sharedDirector] runWithScene:ms ];
	
	
	SimpleAudioEngine *sae = [SimpleAudioEngine sharedEngine];
	if (sae != nil) {
		
		[sae preloadEffect:CONSTANT_SOUNDS_NEWBUTTONSOUND_SOUND1];
		[sae preloadEffect:CONSTANT_VOICE_TALKING];
		[sae preloadEffect:CONSTANT_VOICE_READY];
		[sae preloadEffect:CONSTANT_VOICE_GO];
		[sae preloadEffect:CONSTANT_SOUNDS_BLIP];
		[sae preloadBackgroundMusic:CONSTANT_MUSIC_MAINMENU];
		
		sae.effectsVolume = PSCONFIG_SOUND_VOLUME_EFFECTS;
		
		if (sae.willPlayBackgroundMusic) {
			sae.backgroundMusicVolume = PSCONFIG_SOUND_VOLUME_BACKGROUND;
		}
		//TODO: SONIDO MUTE
		sae.muted = NO;
	}
	//********************	
	shineLogo = [[Animation alloc] initWithName:@"shineLogo" delay:0.066];
	for (int i=1; i<=26; i++) {
		[shineLogo addFrameWithFilename:[[NSString alloc] initWithFormat:@"plussignlogo%04d.png", i]];
	}	//********************
	
	[[UIApplication sharedApplication] setStatusBarHidden:YES animated:YES];
	//[[Director sharedDirector] replaceScene:[IntroScene node]];
	[self loadIntro];
}


- (void)dealloc {
    [super dealloc];
}

- (void) applicationWillResignActive:(UIApplication *)application
{
	[[Director sharedDirector] pause];
	
	UIAlertView *alert = [[UIAlertView alloc] 
						  initWithTitle:@"Resuming Game" 
						  message:@"click OK to resume the game" 
						  delegate:self 
						  cancelButtonTitle:@"OK" 
						  otherButtonTitles:nil];
	[alert show];
	[alert release];
}

- (void) alertView:(UIAlertView *)alertView clickedButtonAtIndex:(NSInteger)buttonIndex
{
	[[Director sharedDirector]resume];
}

@end
