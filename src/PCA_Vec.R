training_csvs <- paste0("TrainingData2/", dir("TrainingData2/"))
df <- do.call(rbind,lapply(training_csvs,read.csv))
df <- df[,-1]
set.seed(0)

head(df)
df <- df[complete.cases(df), ]
df1 <- df[, c(1:14)]
dpca <- prcomp(df1)

dvar <- dpca$sdev^2
temp <- cumsum(dvar)
proportionVar <- temp / temp[14]

# Create Dataframe with Color
PC12Color <- data.frame(dpca$x[,1:2])
PC12Color$Color[df$Ges_Type=='up'] <- 'red'
PC12Color$Color[df$Ges_Type=='down'] <- 'navajowhite2'
PC12Color$Color[df$Ges_Type=='left'] <- 'blue'
PC12Color$Color[df$Ges_Type=='right'] <- 'green'
PC12Color$Color[df$Ges_Type=='follow'] <- 'black'
PC12Color$Color[df$Ges_Type=='none'] <- 'purple'

plot(PC12Color$PC1, PC12Color$PC2, col=PC12Color$Color, type="p", cex=0.2)


# df$Color[df$Ges_Type=='up'] <- 'red'
# df$Color[df$Ges_Type=='down'] <- 'navajowhite2'
# df$Color[df$Ges_Type=='left'] <- 'blue'
# df$Color[df$Ges_Type=='right'] <- 'green'
# df$Color[df$Ges_Type=='none'] <- 'purple'
# plot(df$X3, df$X4, col=df$Color, type="p", cex=0.5)



