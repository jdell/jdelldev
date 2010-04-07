//
//  PSData.m
//  plusSign
//
//  Created by Genki-Oki on 12/22/09.
//  Copyright 2009 Genki-Oki. All rights reserved.
//

#import "PSData.h"


@implementation PSData
@synthesize score, time, mode, signPlus, signMinus, signTimes, signDivision;

+ (PSData *)initPSData:(tMODE)mode
{
	PSData *data = [[PSData alloc] init];
	
	data.mode = mode;
	
	return data;
}
+ (PSData *)initPSData:(tMODE)mode score:(int)points time:(int)seconds plusSign:(bool)plus minusSign:(bool)minus timesSign:(bool)times divisionSign:(bool)division
{
	PSData *data = [[PSData alloc] init];
	
	data.mode = mode;
	data.score = points;
	data.time = seconds;
	data.signPlus = plus;
	data.signMinus = minus;
	data.signTimes = times;
	data.signDivision = division;
	
	return data;
}

+ (PSData *)newPSData
{
	PSData *data = [[PSData alloc] init];
		
	return data;
}

- (BOOL) hasData
{
	NSUserDefaults *prefs = [NSUserDefaults standardUserDefaults];
	NSString *key = [self getKey];
	
	// saving
	NSData *data = [prefs objectForKey:key];	
	return data!=nil;
}

- (void)loadData
{
	
	NSUserDefaults *prefs = [NSUserDefaults standardUserDefaults];
	NSString *key = [self getKey];
	
	// saving
	NSData *data = [prefs objectForKey:key];
	PSData *tmp = (PSData *)[NSKeyedUnarchiver unarchiveObjectWithData:data];
	
	self.mode = tmp.mode;
	self.time = tmp.time;
	self.score = tmp.score;
	self.signPlus = tmp.signPlus;
	self.signMinus = tmp.signMinus;
	self.signTimes = tmp.signTimes;
	self.signDivision = tmp.signDivision;
}
- (void)saveData
{	
	NSUserDefaults *prefs = [NSUserDefaults standardUserDefaults];
	NSString *key = [self getKey];
	
	// saving
	NSData *data = [NSKeyedArchiver archivedDataWithRootObject:self];
	
	[prefs setObject:data forKey:key];
	
	[prefs synchronize];
}

- (BOOL) isGoalReached
{
	int goal;
	switch (self.mode) {
		case CAKE:
			goal = PSCONFIG_GAMEPLAY_GOAL_CAKE;
			break;
		case HAPPY:
			goal = PSCONFIG_GAMEPLAY_GOAL_HAPPY;
			break;
		case TOUGH:
			goal = PSCONFIG_GAMEPLAY_GOAL_TOUGH ;
			break;
		default:
			goal = 0;
			break;
	}
	return self.score>=goal;
}
- (NSString *) getKey
{
	
	NSString *key;
	switch (self.mode) {
		case CAKE:
			key = @"CAKE";
			break;
		case HAPPY:
			key = @"HAPPY";
			break;
		case TOUGH:
			key = @"TOUGH";
			break;
		default:
			key = @"??";
			break;
	}
	return key;
}

- (void)encodeWithCoder:(NSCoder *)encoder
{
	//Encode properties, other class variables, etc
	[encoder encodeInt:mode forKey:@"mode"];
	[encoder encodeInt:time forKey:@"time"];
	[encoder encodeInt:score forKey:@"score"];
	
	[encoder encodeBool:signPlus forKey:@"signPlus"];
	[encoder encodeBool:signMinus forKey:@"signMinus"];
	[encoder encodeBool:signTimes forKey:@"signTimes"];
	[encoder encodeBool:signDivision forKey:@"signDivision"];
}
- (id)initWithCoder:(NSCoder *)decoder
{
	self = [super init];
	if( self != nil )
	{
		//decode properties, other class vars
		self.mode = [decoder decodeIntForKey:@"mode"];
		self.time = [decoder decodeIntForKey:@"time"];
		self.score = [decoder decodeIntForKey:@"score"];
		
		self.signPlus = [decoder decodeBoolForKey:@"signPlus"];
		self.signMinus = [decoder decodeBoolForKey:@"signMinus"];
		self.signTimes = [decoder decodeBoolForKey:@"signTimes"];
		self.signDivision = [decoder decodeBoolForKey:@"signDivision"];
	}
	return self;
}

@end
