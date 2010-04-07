//
//  BackgroundGameLayer.m
//  plusSign
//
//  Created by Genki-Oki on 8/13/09.
//  Copyright 2009 Genki-Oki. All rights reserved.
//

#import "BackgroundGameLayer.h"


@implementation BackgroundGameLayer
- (id) init{
	self = [super init];
	if (self != nil)
	{ 
		
		struct timeval tv;
		gettimeofday( &tv, 0 );
		srandom( tv.tv_usec + tv.tv_sec );
		
		NSMutableArray *allPSBackgrounds = [[NSMutableArray alloc] init];
		[allPSBackgrounds addObject:CONSTANT_BACKGROUND_GAMEPLAY_SEA];
		[allPSBackgrounds addObject:CONSTANT_BACKGROUND_GAMEPLAY_AFRICA];
		[allPSBackgrounds addObject:CONSTANT_BACKGROUND_GAMEPLAY_CITY];
		[allPSBackgrounds addObject:CONSTANT_BACKGROUND_GAMEPLAY_FOREST];
		[allPSBackgrounds addObject:CONSTANT_BACKGROUND_GAMEPLAY_JUNGLE];
		[allPSBackgrounds addObject:CONSTANT_BACKGROUND_GAMEPLAY_SKY];
		[allPSBackgrounds addObject:CONSTANT_BACKGROUND_GAMEPLAY_SNOWFIELD];
		[allPSBackgrounds addObject:CONSTANT_BACKGROUND_GAMEPLAY_SPACE];
		[allPSBackgrounds addObject:CONSTANT_BACKGROUND_GAMEPLAY_VOLCANO];
		
		NSMutableArray *allPSSoundtracks = [[NSMutableArray alloc] init];
		[allPSSoundtracks addObject:CONSTANT_MUSIC_GAMEPLAY_SEA];
		[allPSSoundtracks addObject:CONSTANT_MUSIC_GAMEPLAY_AFRICA];
		[allPSSoundtracks addObject:CONSTANT_MUSIC_GAMEPLAY_CITY];
		[allPSSoundtracks addObject:CONSTANT_MUSIC_GAMEPLAY_FOREST];
		[allPSSoundtracks addObject:CONSTANT_MUSIC_GAMEPLAY_JUNGLE];
		[allPSSoundtracks addObject:CONSTANT_MUSIC_GAMEPLAY_SKY];
		[allPSSoundtracks addObject:CONSTANT_MUSIC_GAMEPLAY_SNOWFIELD];
		[allPSSoundtracks addObject:CONSTANT_MUSIC_GAMEPLAY_SPACE];
		[allPSSoundtracks addObject:CONSTANT_MUSIC_GAMEPLAY_VOLCANO];
		
		
		int index = (random() % [allPSBackgrounds count]);
		NSString *fileBackground = (NSString*)[allPSBackgrounds objectAtIndex:index];//[[NSString alloc] ini initWithFormat:@"background_%d.jpg", background];
		
		Sprite * bgBlue = [Sprite spriteWithFile:fileBackground];
		[bgBlue setPosition:ccp(160, 240)];
		[self addChild:bgBlue z:0];
		
		currentBackground = fileBackground;
		
		NSString *fileSoundtrack = (NSString*)[allPSSoundtracks objectAtIndex:index];
		[[SimpleAudioEngine sharedEngine] playBackgroundMusic:fileSoundtrack];
		
	}
	return self;
}
@end
